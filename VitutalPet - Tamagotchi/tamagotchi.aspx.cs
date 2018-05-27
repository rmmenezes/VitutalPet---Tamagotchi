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

        protected String Homer()
        {
            return " <div id='homer'> <div class='head'> <div class='hair1'></div><div class='hair2'></div><div class='body head-top'></div><div class='no-border body head-main'></div><div class='no-border m1'></div><div class='no-border m2'></div><div class='no-border m3'></div><div class='no-border m4'></div><div class='no-border neck1'></div><div class='body neck2'></div><div class='body ear'> <div class='no-border inner1'></div><div class='no-border inner2'></div><div class='no-border body clip'></div></div><div class='mouth'> <div class='mouth5'></div><div class='mouth2'></div><div class='mouth1'></div><div class='mouth7'></div><div class='no-border mouth3'></div><div class='no-border mouth4'></div><div class='no-border mouth6'></div><div class='no-border mouth8'></div></div><div class='right-eye'> <div class='no-border right-eye-pupil'></div><div class='no-border body eyelid-top'></div><div class='no-border body eyelid-bottom'></div></div><div class='body nose'></div><div class='body nose-tip'></div><div class='left-eye'> <div class='no-border left-eye-pupil'></div><div class='no-border body eyelid-top'></div><div class='no-border body eyelid-bottom'></div></div></div></div>";
        }


        protected void Tamagotchi(float fome, float saude, float felicidade, float sono, DateTime lastTime, string estado, Tamagotchi t, IMongoDatabase database)
        {
            int txFome, txSaude, txFelicidade, txSono; //taxas de decaimento (muda de acordo com o estado)

            TimeSpan deltaTime = lastTime - DateTime.Now;
            if (estado == "normal")
            {
                txFome = 3; txFelicidade = 2; txSaude = 2; txSono = 2;

                fome = fome - ((txFome * (int)deltaTime.Hours) / 4);
                saude = saude - ((txSaude * (int)deltaTime.Hours) / 4);
                felicidade = felicidade - ((txFelicidade * (int)deltaTime.Hours) / 4);
                sono = sono + ((txSono * (int)deltaTime.Hours) / 4);

                if (fome <= 0 || saude <= 0 || felicidade <= 0)
                {
                    estado = "morto";
                }
                else if (saude < 25)
                {
                    estado = "doente";
                }
                else if (felicidade < 25)
                {
                    estado = "triste";
                }
                else if (sono > 80)
                {
                    estado = "cansado";
                }

            }
            else if (estado == "doente")
            {
                txFome = 3; txFelicidade = 5; txSaude = 7; txSono = 4;

                fome = fome - ((txFome * (int)deltaTime.Hours) / 4);
                saude = saude - ((txSaude * (int)deltaTime.Hours) / 4);
                felicidade = felicidade - ((txFelicidade * (int)deltaTime.Hours) / 4);
                sono = sono + ((txSono * (int)deltaTime.Hours) / 4);

                if (fome <= 0 || saude <= 0 || felicidade <= 0)
                {
                    estado = "morto";
                }
                else if (saude < 25)
                {
                    estado = "doente";
                }
                else if (felicidade < 25)
                {
                    estado = "triste";
                }
                else if (sono > 80)
                {
                    estado = "cansado";
                }
            }
            else if (estado == "cansado")
            {
                txFome = 3; txFelicidade = 4; txSaude = 4; txSono = 15;

                fome = fome - ((txFome * (int)deltaTime.Hours) / 4);
                saude = saude - ((txSaude * (int)deltaTime.Hours) / 4);
                felicidade = felicidade - ((txFelicidade * (int)deltaTime.Hours) / 4);
                sono = sono + ((txSono * (int)deltaTime.Hours) / 4);

                if (fome <= 0 || saude <= 0 || felicidade <= 0)
                {
                    estado = "morto";
                }
                else if (saude < 25)
                {
                    estado = "doente";
                }
                else if (felicidade < 25)
                {
                    estado = "triste";
                }
                else if (sono > 80)
                {
                    estado = "cansado";
                }
            }
            else if (estado == "sujo")
            {
                txFome = 3; txFelicidade = 5; txSaude = 6; txSono = 1;

                fome = fome - ((txFome * (int)deltaTime.Hours) / 4);
                saude = saude - ((txSaude * (int)deltaTime.Hours) / 4);
                felicidade = felicidade - ((txFelicidade * (int)deltaTime.Hours) / 4);
                sono = sono + ((txSono * (int)deltaTime.Hours) / 4);

                if (fome <= 0 || saude <= 0 || felicidade <= 0)
                {
                    estado = "morto";
                }
                else if (saude < 25)
                {
                    estado = "doente";
                }
                else if (felicidade < 25)
                {
                    estado = "triste";
                }
                else if (sono > 80)
                {
                    estado = "cansado";
                }
            }
            else if (estado == "triste")
            {
                txFome = 1; txFelicidade = 7; txSaude = 6; txSono = 10;

                fome = fome - ((txFome * (int)deltaTime.Hours) / 4);
                saude = saude - ((txSaude * (int)deltaTime.Hours) / 4);
                felicidade = felicidade - ((txFelicidade * (int)deltaTime.Hours) / 4);
                sono = sono + ((txSono * (int)deltaTime.Hours) / 4);

                if (fome <= 0 || saude <= 0 || felicidade <= 0)
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
                if (sono < 25)
                {
                    estado = "cansado";
                }
            }
            else if (estado == "dormindo")
            {
                txFome = 1; txFelicidade = 0; txSaude = 0; txSono = 5;

                fome = fome - ((txFome * (int)deltaTime.Hours) / 4);
                saude = saude + ((txSaude * (int)deltaTime.Hours) / 4);
                felicidade = felicidade - ((txFelicidade * (int)deltaTime.Hours) / 4);
                sono = sono - ((txSono * (int)deltaTime.Hours) / 4);

                if (fome <= 0 || saude <= 0 || felicidade <= 0)
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
                if (sono > 80)
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
            barra_sono.Attributes["style"] = "width: " + sono.ToString() + "%;";
            barra_felicidade.Attributes["style"] = "width: " + felicidade.ToString() + "%;";
            barra_fome.Attributes["style"] = "width: " + fome.ToString() + "%;";
            barra_vida.Attributes["style"] = "width: " + saude.ToString() + "%;";
            Update_Tamagotchi((int)fome, (int)saude, (int)felicidade, (int)sono, lastTime, estado, t, database);
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
        public void Cerveja(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("TesteTamagotchi");

            String nome_UserLogged = Session["Auth"].ToString();    //Nome do user logado
            Tamagotchi tamagotchi_Logged = Get_tamagotchi(database, nome_UserLogged); //pego o tamagotchi dele

            int fome = tamagotchi_Logged.Fome, saude = tamagotchi_Logged.Saude, felicidade = tamagotchi_Logged.Felicidade, sono = tamagotchi_Logged.Sono;
            Update_Tamagotchi(fome + 7, saude - 3, felicidade + 4, sono, tamagotchi_Logged.Tempo, tamagotchi_Logged.Estado, tamagotchi_Logged, database);
        }

        public void Donuts(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("TesteTamagotchi");

            String nome_UserLogged = Session["Auth"].ToString();    //Nome do user logado
            Tamagotchi tamagotchi_Logged = Get_tamagotchi(database, nome_UserLogged); //pego o tamagotchi dele

            int fome = tamagotchi_Logged.Fome, saude = tamagotchi_Logged.Saude, felicidade = tamagotchi_Logged.Felicidade, sono = tamagotchi_Logged.Sono;
            Update_Tamagotchi(fome + 10, saude - 2, felicidade + 3, sono, tamagotchi_Logged.Tempo, tamagotchi_Logged.Estado, tamagotchi_Logged, database);
        }

        public void Frango(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("TesteTamagotchi");

            String nome_UserLogged = Session["Auth"].ToString();    //Nome do user logado
            Tamagotchi tamagotchi_Logged = Get_tamagotchi(database, nome_UserLogged); //pego o tamagotchi dele

            int fome = tamagotchi_Logged.Fome, saude = tamagotchi_Logged.Saude, felicidade = tamagotchi_Logged.Felicidade, sono = tamagotchi_Logged.Sono;
            Update_Tamagotchi(fome + 15, saude + 3, felicidade + 1, sono, tamagotchi_Logged.Tempo, tamagotchi_Logged.Estado, tamagotchi_Logged, database);
        }

        public void Sofa(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("TesteTamagotchi");

            String nome_UserLogged = Session["Auth"].ToString();    //Nome do user logado
            Tamagotchi tamagotchi_Logged = Get_tamagotchi(database, nome_UserLogged); //pego o tamagotchi dele

            int fome = tamagotchi_Logged.Fome, saude = tamagotchi_Logged.Saude, felicidade = tamagotchi_Logged.Felicidade, sono = tamagotchi_Logged.Sono;
            Update_Tamagotchi(fome, saude + 15, felicidade, sono - 40, tamagotchi_Logged.Tempo, tamagotchi_Logged.Estado, tamagotchi_Logged, database);
        }

        public void Cama(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("TesteTamagotchi");

            String nome_UserLogged = Session["Auth"].ToString();    //Nome do user logado
            Tamagotchi tamagotchi_Logged = Get_tamagotchi(database, nome_UserLogged); //pego o tamagotchi dele

            int fome = tamagotchi_Logged.Fome, saude = tamagotchi_Logged.Saude, felicidade = tamagotchi_Logged.Felicidade, sono = tamagotchi_Logged.Sono;
            Update_Tamagotchi(fome, saude, felicidade, sono, tamagotchi_Logged.Tempo, tamagotchi_Logged.Estado = "dormindo", tamagotchi_Logged, database);
        }
    }
}