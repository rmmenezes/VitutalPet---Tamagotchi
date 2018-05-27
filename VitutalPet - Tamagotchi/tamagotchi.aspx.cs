using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VitutalPet___Tamagotchi.Models;

namespace VitutalPet___Tamagotchi
{



    public partial class tamagotchi : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("TesteTamagotchi");

            String nome_UserLogged = Session["Auth"].ToString();    //Nome do user logado
            Tamagotchi tamagotchi_Logged = Get_tamagotchi(database, nome_UserLogged); //pego o tamagotchi dele

            string estado = tamagotchi_Logged.Estado;
            int fome = tamagotchi_Logged.Fome, saude = tamagotchi_Logged.Saude, felicidade = tamagotchi_Logged.Felicidade, sono = tamagotchi_Logged.Sono;        //indices do pet (definem o estado)
            DateTime tempo = tamagotchi_Logged.Tempo;
            Tamagotchi(fome, saude, felicidade, sono, tempo, estado, tamagotchi_Logged, database);
        }

        public void OpenGameBoll(object sender, EventArgs e)
        {
            Response.Redirect("game1.aspx");
        }

        

        protected void Tamagotchi(int fome, int saude, int felicidade, int sono, DateTime lastTime, string estado, Tamagotchi t, IMongoDatabase database)
        {
            //int txFome, txSaude, txFelicidade, txSono; //taxas de decaimento (muda de acordo com o estado)

            TimeSpan deltaTime = DateTime.Now - lastTime;
            if (estado == "normal")
            {
                //txFome = 3; txFelicidade = 2; txSaude = 2; txSono = 2;

                //fome += (txFome * (int)deltaTime.TotalHours) / 20;
                //saude -= (txSaude * (int)deltaTime.TotalHours) / 20;
                //felicidade -= (txFelicidade * (int)deltaTime.TotalHours) / 20;
                //sono += (txSono * (int)deltaTime.TotalHours) / 20;

                fome = fome + 1;
                saude = saude - 1;
                felicidade = felicidade - 1;
                sono = sono + 1;

                if (saude < 25)
                {
                    estado = "doente";
                }
                if (felicidade < 25)
                {
                    estado = "triste";
                }
                if (sono > 25)
                {
                    estado = "cansado";
                }
            }

            else if (estado == "doente")
            {
                //txFome = 3; txFelicidade = 5; txSaude = 7; txSono = 4;

                //fome += (txFome * (int)deltaTime.TotalHours) / 20;
                //saude -= (txSaude * (int)deltaTime.TotalHours) / 20;
                //felicidade -= (txFelicidade * (int)deltaTime.TotalHours) / 20;
                //sono += (txSono * (int)deltaTime.TotalHours) / 20;

                fome = fome + 1;
                saude = saude - 1;
                felicidade = felicidade - 1;
                sono = sono + 1;

                if (fome >= 100 && saude <= 0 && felicidade <= 0)
                {
                    estado = "morto";
                }

                if (saude < 25)
                {
                    estado = "doente";
                }
                if (felicidade < 25)
                {
                    estado = "triste";
                }
                if (sono > 25)
                {
                    estado = "cansado";
                }
            }

            else if (estado == "cansado")
            {
                //txFome = 3; txFelicidade = 4; txSaude = 4; txSono = 15;

                //fome += (txFome * (int)deltaTime.TotalHours) / 20;
                //saude -= (txSaude * (int)deltaTime.TotalHours) / 20;
                //felicidade -= (txFelicidade * (int)deltaTime.TotalHours) / 20;
                //sono += (txSono * (int)deltaTime.TotalHours) / 20;

                fome = fome + 1;
                saude = saude - 1;
                felicidade = felicidade - 1;
                sono = sono + 1;

                if (fome >= 100 && saude <= 0 && felicidade <= 0)
                {
                    estado = "morto";
                }

                if (saude < 25)
                {
                    estado = "doente";
                }
                if (felicidade < 25)
                {
                    estado = "triste";
                }
                if (sono > 25)
                {
                    estado = "cansado";
                }
            }
            else if (estado == "triste")
            {
                //txFome = 1; txFelicidade = 7; txSaude = 6; txSono = 10;

                //fome += (txFome * (int)deltaTime.TotalHours) / 20;
                //saude -= (txSaude * (int)deltaTime.TotalHours) / 20;
                //felicidade -= (txFelicidade * (int)deltaTime.TotalHours) / 20;
                //sono += (txSono * (int)deltaTime.TotalHours) / 20;

                if (fome >= 100 && saude <= 0 && felicidade <= 0)
                {
                    estado = "morto";
                }

                if (saude < 25)
                {
                    estado = "doente";
                }
                if (felicidade < 25)
                {
                    estado = "triste";
                }
                if (sono > 25)
                {
                    estado = "cansado";
                }
            }
            else if (estado == "dormindo")
            {
                //txFome = 1; txFelicidade = 0; txSaude = 0; txSono = 5;

                //fome += (txFome * (int)deltaTime.TotalHours) / 20;
                //saude -= (txSaude * (int)deltaTime.TotalHours) / 20;
                //felicidade -= (txFelicidade * (int)deltaTime.TotalHours) / 20;
                //sono += (txSono * (int)deltaTime.TotalHours) / 20;

                fome = fome + 1;
                saude = saude - 1;
                felicidade = felicidade - 1;
                sono = sono + 1;

                if (fome >= 100 && saude <= 0 && felicidade <= 0)
                {
                    estado = "morto";
                }

                if (saude < 25)
                {
                    estado = "doente";
                }
                if (felicidade < 25)
                {
                    estado = "triste";
                }
                if (sono > 25)
                {
                    estado = "cansado";
                }
            }

            else if (estado == "morto")
            {
                //txFome = 8000; txFelicidade = 8000; txSaude = 8000;

                fome = 0;
                saude = 0;
                felicidade = 0;
            }
            barra_fome.Attributes["style"] = "width: " + fome.ToString() + "%;";
            barra_sono.Attributes["style"] = "width: " + sono.ToString() + "%;";
            barra_felicidade.Attributes["style"] = "width: " + felicidade.ToString() + "%;";
            barra_vida.Attributes["style"] = "width: " + saude.ToString() + "%;";

            Update_Tamagotchi(fome, saude, felicidade, sono, lastTime, estado, t, database);
        }

        private void Update_Tamagotchi(int fome, int saude, int felicidade, int sono, DateTime lastTime, string estado, Tamagotchi t, IMongoDatabase database)
        {
            var tamagotchis = database.GetCollection<Tamagotchi>("tamagotchi");

            var filtro = Builders<Tamagotchi>.Filter.Where(x => x.Nome_Tamagotchi == t.Nome_Tamagotchi);

            var change = Builders<Tamagotchi>.Update.Set(x => x.Estado, estado)
                                                    .Set(x => x.Fome, fome)
                                                    .Set(x => x.Saude, saude)
                                                    .Set(x => x.Felicidade, felicidade)
                                                    .Set(x => x.Sono, sono)
                                                    .Set(x => x.Tempo, lastTime);
                                                    
            tamagotchis.UpdateOne(filtro, change);
        }

        private void Update_Fome(int fome, Tamagotchi t, IMongoDatabase database)
        {
            var tamagotchis = database.GetCollection<Tamagotchi>("tamagotchi");
            var filtro = Builders<Tamagotchi>.Filter.Where(x => x.Nome_Tamagotchi == t.Nome_Tamagotchi);
            var change = Builders<Tamagotchi>.Update.Set(x => x.Fome , fome);
            tamagotchis.UpdateOne(filtro, change);
        }

        protected void GiveFood(object sender, ImageClickEventArgs e)
	    {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("TesteTamagotchi");
            String nome_UserLogged = Session["Auth"].ToString();    //Nome do user logado

            Tamagotchi tamagotchi_Logged = Get_tamagotchi(database, nome_UserLogged); //pego o tamagotchi dele
            
            var imageButton = sender as ImageButton; 
            
            if (imageButton.ID == "food1") 
            {
                Update_Fome(tamagotchi_Logged.Fome + 30,tamagotchi_Logged,database);
            }else if(imageButton.ID == "food2")
            {
                Update_Fome(tamagotchi_Logged.Fome + 50, tamagotchi_Logged, database);
            }
            else if(imageButton.ID == "food3")
            {
                Update_Fome(tamagotchi_Logged.Fome + 10, tamagotchi_Logged, database);
            }
        }

        private Tamagotchi Get_tamagotchi(IMongoDatabase database, string nome_UserLogged)
        {
            var tamagotchis = database.GetCollection<Tamagotchi>("tamagotchi");
            var res = tamagotchis.Find(x => x.Nome_User == nome_UserLogged);
            if (res.Count() != 0)
            {
                return res.ToList().First();
            }
            else
            {
                return null;
            }
        }

        protected string Function()
        {
            return "<h1>Ola</h1>";
        }

        public String Per()
        {
            if (Session["Personagem"].ToString() == "Homer")
            {
                return " <div id='homer'> <div class='head'> <div class='hair1'></div><div class='hair2'></div><div class='body head-top'></div><div class='no-border body head-main'></div><div class='no-border m1'></div><div class='no-border m2'></div><div class='no-border m3'></div><div class='no-border m4'></div><div class='no-border neck1'></div><div class='body neck2'></div><div class='body ear'> <div class='no-border inner1'></div><div class='no-border inner2'></div><div class='no-border body clip'></div></div><div class='mouth'> <div class='mouth5'></div><div class='mouth2'></div><div class='mouth1'></div><div class='mouth7'></div><div class='no-border mouth3'></div><div class='no-border mouth4'></div><div class='no-border mouth6'></div><div class='no-border mouth8'></div></div><div class='right-eye'> <div class='no-border right-eye-pupil'></div><div class='no-border body eyelid-top'></div><div class='no-border body eyelid-bottom'></div></div><div class='body nose'></div><div class='body nose-tip'></div><div class='left-eye'> <div class='no-border left-eye-pupil'></div><div class='no-border body eyelid-top'></div><div class='no-border body eyelid-bottom'></div></div></div></div>";
            }
            else if (Session["Personagem"].ToString() == "Bart")
            {
                return "<div id = 'bart' > < div class='head'> <div class='no-border body hair hair1'></div><div class='no-border body hair hair2'></div><div class='no-border body hair hair3'></div><div class='no-border body hair hair4'></div><div class='no-border body hair hair5'></div><div class='no-border body hair hair6'></div><div class='no-border body hair hair7'></div><div class='no-border body hair hair8'></div><div class='no-border body hair hair9'></div><div class='body mouth-lip2'></div><div class='no-border body head-left1'></div><div class='no-border body head-left2'></div><div class='no-border body head-left3'></div><div class='no-border body head-left4'></div><div class='no-border body head-left5'></div><div class='no-border body head-left6'></div><div class='no-border body head-left7'></div><div class='body eyelid'></div><div class='no-border body mouth'></div><div class='body mouth-lip'></div><div class='no-border body head-right2'></div><div class='no-border body head-right1'></div><div class='no-border body head-right3'></div><div class='body ear'> <div class='no-border inner1'></div><div class='no-border inner2'></div><div class='no-border body clip'></div></div><div class='right-eye'> <div class='no-border right-eye-pupil'></div><div class='no-border body eyelid-top'></div><div class='no-border body eyelid-bottom'></div></div><div class='no-border body nose'></div><div class='body nose-tip'></div><div class='left-eye'> <div class='no-border left-eye-pupil'></div><div class='no-border body eyelid-top'></div><div class='no-border body eyelid-bottom'></div></div><div class='no-border mouth-smile'></div></div></div>";
            }
            else
            {
                return "0";
            }
        }


    }

}