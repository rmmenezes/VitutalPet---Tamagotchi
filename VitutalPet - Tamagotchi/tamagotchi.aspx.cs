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
            string personagem = Session["Personagem"].ToString();
            if (personagem == "Homer"){
                return " <div id='homer'> <div class='head'> <div class='hair1'></div><div class='hair2'></div><div class='body head-top'></div><div class='no-border body head-main'></div><div class='no-border m1'></div><div class='no-border m2'></div><div class='no-border m3'></div><div class='no-border m4'></div><div class='no-border neck1'></div><div class='body neck2'></div><div class='body ear'> <div class='no-border inner1'></div><div class='no-border inner2'></div><div class='no-border body clip'></div></div><div class='mouth'> <div class='mouth5'></div><div class='mouth2'></div><div class='mouth1'></div><div class='mouth7'></div><div class='no-border mouth3'></div><div class='no-border mouth4'></div><div class='no-border mouth6'></div><div class='no-border mouth8'></div></div><div class='right-eye'> <div class='no-border right-eye-pupil'></div><div class='no-border body eyelid-top'></div><div class='no-border body eyelid-bottom'></div></div><div class='body nose'></div><div class='body nose-tip'></div><div class='left-eye'> <div class='no-border left-eye-pupil'></div><div class='no-border body eyelid-top'></div><div class='no-border body eyelid-bottom'></div></div></div></div>";
            } else if (personagem == "Lisa"){
                return "<div id='lisa'> <div class='head'> <div class='no-border body head-main'></div><div class='no-border body head-main2'></div><div class='no-border body head-main3'></div><div class='no-border hair9'></div><div class='no-border hair10'></div><div class='body hair hair1'></div><div class='body hair hair2'></div><div class='body hair hair3'></div><div class='body hair hair4'></div><div class='body hair hair5'></div><div class='body hair hair6'></div><div class='body hair hair7'></div><div class='body hair hair8'></div><div class='body mouth-lip2'></div><div class='body mouth-lip'></div><div class='no-border body neck'></div><div class='no-border body mouth'></div><div class='no-border body neck2'></div><div class='no-border body neck3'></div><div class='no-border mouth-smile'></div><div class='body ear'> <div class='no-border inner1'></div><div class='no-border inner2'></div><div class='no-border body clip'></div></div><div class='no-border eyelash1 eyelash'></div><div class='no-border eyelash2 eyelash'></div><div class='no-border eyelash3 eyelash'></div><div class='no-border eyelash4 eyelash'></div><div class='no-border eyelash5 eyelash'></div><div class='no-border eyelash6 eyelash'></div><div class='no-border eyelash7 eyelash'></div><div class='no-border eyelash8 eyelash'></div><div class='right-eye'> <div class='no-border right-eye-pupil'></div><div class='no-border body eyelid-top'></div><div class='no-border body eyelid-bottom'></div></div><div class='no-border body nose'></div><div class='body nose-tip'></div><div class='left-eye'> <div class='no-border left-eye-pupil'></div><div class='no-border body eyelid-top'></div><div class='no-border body eyelid-bottom'></div></div><div class='necklace necklace1'></div><div class='necklace necklace2'></div><div class='necklace necklace3'></div><div class='necklace necklace5'></div><div class='necklace necklace4'></div></div></div>";
            } else if (personagem == "Bart"){
                return "<div id='bart'> <div class='head'> <div class='no-border body hair hair1'></div><div class='no-border body hair hair2'></div><div class='no-border body hair hair3'></div><div class='no-border body hair hair4'></div><div class='no-border body hair hair5'></div><div class='no-border body hair hair6'></div><div class='no-border body hair hair7'></div><div class='no-border body hair hair8'></div><div class='no-border body hair hair9'></div><div class='body mouth-lip2'></div><div class='no-border body head-left1'></div><div class='no-border body head-left2'></div><div class='no-border body head-left3'></div><div class='no-border body head-left4'></div><div class='no-border body head-left5'></div><div class='no-border body head-left6'></div><div class='no-border body head-left7'></div><div class='body eyelid'></div><div class='no-border body mouth'></div><div class='body mouth-lip'></div><div class='no-border body head-right2'></div><div class='no-border body head-right1'></div><div class='no-border body head-right3'></div><div class='body ear'> <div class='no-border inner1'></div><div class='no-border inner2'></div><div class='no-border body clip'></div></div><div class='right-eye'> <div class='no-border right-eye-pupil'></div><div class='no-border body eyelid-top'></div><div class='no-border body eyelid-bottom'></div></div><div class='no-border body nose'></div><div class='body nose-tip'></div><div class='left-eye'> <div class='no-border left-eye-pupil'></div><div class='no-border body eyelid-top'></div><div class='no-border body eyelid-bottom'></div></div><div class='no-border mouth-smile'></div></div></div>";
            } else if (personagem == "Ned"){
                return "<div id='ned-flanders'><div class='head'> <div class='hair-top hair'></div><div class='hair-side hair'></div><div class='no-border neck-bottom'></div><div class='no-border neck-left'></div><div class='body lip'></div><div class='no-border body head-main'></div><div class='no-border hair-line1 hair-line'></div><div class='no-border hair-line2 hair-line'></div><div class='no-border hair-line3 hair-line'></div><div class='no-border hair-line4 hair-line'></div><div class='no-border hair-line5 hair-line'></div><div class='body head-top'></div><div class='no-border body eye-bulge'></div><div class='no-border body head-top-inner'></div><div class='no-border neck-right'></div><div class='body ear'><div class='no-border inner'></div></div><div class='no-border sideburn hair'></div><div class='no-border body head-side'></div><div class='left-eye eye'><div class='no-border pupil'></div><div class='no-border body eyelid-top'></div><div class='no-border body eyelid-bottom'></div></div><div class='right-eye eye'><div class='no-border pupil'></div><div class='no-border body eyelid-top'></div><div class='no-border body eyelid-bottom'></div></div><div class='no-border glasses'></div><div class='no-border mouth-top'></div><div class='no-border mouth-left'></div><div class='no-border mouth-right'></div><div class='no-border mouth-bottom'></div><div class='no-border mouth-inner'></div><div class='no-border tongue'></div><div class='moustache'><div class='no-border moustache-hair1 hair left'></div><div class='no-border moustache-hair2 hair left'></div><div class='no-border moustache-hair3 hair left'></div><div class='no-border moustache-hair4 hair right'></div><div class='no-border moustache-hair5 hair right'></div><div class='no-border moustache-hair6 hair right'></div></div><div class='body nose'></div></div></div>";
            } else if (personagem == "Marge"){
                return "<div id='marge'> <div class='head'> <div class='no-border body head-main'></div><div class='body mouth-lip2'></div><div class='body mouth-lip'></div><div class='no-border body neck'></div><div class='no-border body mouth'></div><div class='no-border body neck2'></div><div class='no-border body neck3'></div><div class='no-border mouth-smile'></div><div class='hair hair1 hair-circle'></div><div class='hair hair2 hair-circle'></div><div class='hair hair3 hair-circle'></div><div class='hair hair4 hair-circle'></div><div class='hair hair5 hair-circle'></div><div class='hair hair6 hair-circle'></div><div class='hair hair7 hair-circle'></div><div class='hair hair8 hair-circle'></div><div class='hair hair9 hair-circle'></div><div class='hair hair10 hair-circle'></div><div class='hair hair11 hair-circle'></div><div class='hair hair12 hair-circle'></div><div class='hair hair13 hair-circle'></div><div class='hair hair14 hair-circle'></div><div class='hair hair15 hair-circle'></div><div class='hair hair16 hair-circle'></div><div class='hair hair17 hair-circle'></div><div class='hair hair18 hair-circle'></div><div class='hair hair19 hair-circle'></div><div class='hair hair20 hair-circle'></div><div class='hair hair21 hair-circle'></div><div class='hair hair22 hair-circle'></div><div class='hair hair23 hair-circle'></div><div class='hair hair24 hair-circle'></div><div class='hair hair25 hair-circle'></div><div class='hair hair26 hair-circle'></div><div class='hair hair27 hair-circle'></div><div class='hair hair28 hair-circle'></div><div class='hair hair29 hair-circle'></div><div class='hair hair30 hair-circle'></div><div class='no-border hair hair-main'></div><div class='no-border hair hair-main2'></div><div class='no-border hair hair-main3'></div><div class='no-border hair hair-main4'></div><div class='no-border hair hair-main5'></div><div class='no-border hair hair-main6'></div><div class='no-border hair hair-main7 hair-circle'></div><div class='body ear'> <div class='no-border inner1'></div><div class='no-border inner2'></div><div class='no-border body clip'></div></div><div class='no-border eyelash1 eyelash'></div><div class='no-border eyelash2 eyelash'></div><div class='no-border eyelash3 eyelash'></div><div class='no-border eyelash4 eyelash'></div><div class='no-border eyelash5 eyelash'></div><div class='no-border eyelash6 eyelash'></div><div class='no-border eyelash7 eyelash'></div><div class='no-border eyelash8 eyelash'></div><div class='right-eye'> <div class='no-border right-eye-pupil'></div><div class='no-border body eyelid-top'></div><div class='no-border body eyelid-bottom'></div></div><div class='no-border body nose'></div><div class='body nose-tip'></div><div class='left-eye'> <div class='no-border left-eye-pupil'></div><div class='no-border body eyelid-top'></div><div class='no-border body eyelid-bottom'></div></div></div></div>";
            } else {
                return "<div id='maggie'> <div class='head'> <div class='no-border body head-main'></div><div class='body hair hair2'></div><div class='body hair hair1'></div><div class='body hair hair3'></div><div class='body hair hair4'></div><div class='body hair hair5'></div><div class='body hair hair6'></div><div class='body hair hair7'></div><div class='body hair hair8'></div><div class='bow bow1'></div><div class='circle bow bow2'></div><div class='bow bow3'></div><div class='no-border body neck'></div><div class='circle body ear'> <div class='no-border circle inner1'></div><div class='no-border circle inner2'></div><div class='no-border body clip'></div></div><div class='circle body cheek'></div><div class='no-border eyelash1 eyelash'></div><div class='no-border eyelash2 eyelash'></div><div class='no-border eyelash3 eyelash'></div><div class='no-border eyelash4 eyelash'></div><div class='no-border eyelash5 eyelash'></div><div class='no-border eyelash6 eyelash'></div><div class='no-border eyelash7 eyelash'></div><div class='no-border eyelash8 eyelash'></div><div class='circle eye right-eye'> <div class='no-border circle pupil'></div><div class='no-border body eyelid-top'></div><div class='no-border body eyelid-bottom'></div></div><div class='body nose-tip'></div><div class='circle eye left-eye'> <div class='no-border circle pupil'></div><div class='no-border body eyelid-top'></div><div class='no-border body eyelid-bottom'></div></div><div class='circle body mouth'></div><div class='circle dummy dummy1'></div><div class='dummy dummy2'><div class='dummy dummy3'></div></div></div></div>";
            }
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