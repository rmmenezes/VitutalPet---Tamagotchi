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
        string estado;
        int fome, saude, felicidade, sono;        //indices do pet (definem o estado)
        int txFome, txSaude, txFelicidade, txSono; //taxas de decaimento (muda de acordo com o estado)
        //
        bool noite = false;


        protected void BT_dormir(object sender, EventArgs e)
        {

            if (noite == false)
            {
                background.Attributes["style"] = "background-color: #070317; opacity: 0.2";
                barraSono.Attributes["style"] = "width: 100%;";
                noite = true;
            }
            if (noite == true)
            {
                background.Attributes["style"] = "background-color: #070317; opacity: 1";
                barraSono.Attributes["style"] = "width: 0%;";
                noite = false;

            }
        }

        protected void Conect(object sender, EventArgs e)
        {
            var c = new MongoDB.Driver.MongoClient();
            var db = c.GetDatabase("TesteTamagotchi");
            var coll = db.GetCollection<User>("User");

            var t = coll
                .Find(b => b.Username == "Rafael")
                .Limit(1)
                .ToListAsync()
                .Result;
            var s = Session["Auth"];

            //Tamagotchi(sender, e, t[0], 0);
        }

        protected String Homer()
        {
            return " <div id='homer'> <div class='head'> <div class='hair1'></div><div class='hair2'></div><div class='body head-top'></div><div class='no-border body head-main'></div><div class='no-border m1'></div><div class='no-border m2'></div><div class='no-border m3'></div><div class='no-border m4'></div><div class='no-border neck1'></div><div class='body neck2'></div><div class='body ear'> <div class='no-border inner1'></div><div class='no-border inner2'></div><div class='no-border body clip'></div></div><div class='mouth'> <div class='mouth5'></div><div class='mouth2'></div><div class='mouth1'></div><div class='mouth7'></div><div class='no-border mouth3'></div><div class='no-border mouth4'></div><div class='no-border mouth6'></div><div class='no-border mouth8'></div></div><div class='right-eye'> <div class='no-border right-eye-pupil'></div><div class='no-border body eyelid-top'></div><div class='no-border body eyelid-bottom'></div></div><div class='body nose'></div><div class='body nose-tip'></div><div class='left-eye'> <div class='no-border left-eye-pupil'></div><div class='no-border body eyelid-top'></div><div class='no-border body eyelid-bottom'></div></div></div></div>";
        }

        

        protected void Tamagotchi(object sender, EventArgs e,  User t, DateTime lastTime)
        {
            
            TimeSpan deltaTime = DateTime.Now - lastTime;
            if (estado == "normal")
            {
                txFome = 3; txFelicidade = 2; txSaude = 2; txSono = 2;

                fome -= (txFome * (int)deltaTime.TotalHours) / 20;
                saude -= (txSaude * (int)deltaTime.TotalHours) / 20;
                felicidade -= (txFelicidade * (int)deltaTime.TotalHours) / 20;
                sono -= (txSono * (int)deltaTime.TotalHours) / 20;

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
            else if (estado == "doente")
            {
                txFome = 3; txFelicidade = 5; txSaude = 7; txSono = 4;

                fome -= (txFome * (int)deltaTime.TotalHours) / 20;
                saude -= (txSaude * (int)deltaTime.TotalHours) / 20;
                felicidade -= (txFelicidade * (int)deltaTime.TotalHours) / 20;
                sono -= (txSono * (int)deltaTime.TotalHours) / 20;

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
            else if (estado == "cansado")
            {
                txFome = 3; txFelicidade = 4; txSaude = 4; txSono = 15;

                fome -= (txFome * (int)deltaTime.TotalHours) / 20;
                saude -= (txSaude * (int)deltaTime.TotalHours) / 20;
                felicidade -= (txFelicidade * (int)deltaTime.TotalHours) / 20;
                sono -= (txSono * (int)deltaTime.TotalHours) / 20;

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
            else if (estado == "sujo")
            {
                txFome = 3; txFelicidade = 5; txSaude = 6; txSono = 1;

                fome -= (txFome * (int)deltaTime.TotalHours) / 20;
                saude -= (txSaude * (int)deltaTime.TotalHours) / 20;
                felicidade -= (txFelicidade * (int)deltaTime.TotalHours) / 20;
                sono -= (txSono * (int)deltaTime.TotalHours) / 20;

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
            else if (estado == "triste")
            {
                txFome = 1; txFelicidade = 7; txSaude = 6; txSono = 10;

                fome -= (txFome * (int)deltaTime.TotalHours) / 20;
                saude -= (txSaude * (int)deltaTime.TotalHours) / 20;
                felicidade -= (txFelicidade * (int)deltaTime.TotalHours) / 20;
                sono -= (txSono * (int)deltaTime.TotalHours) / 20;

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

                fome -= (txFome * (int)deltaTime.TotalHours) / 20;
                saude -= (txSaude * (int)deltaTime.TotalHours) / 20;
                felicidade -= (txFelicidade * (int)deltaTime.TotalHours) / 20;
                sono += (txSono * (int)deltaTime.TotalHours) / 20;

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
            else if (estado == "morto")
            {
                txFome = 8000; txFelicidade = 8000; txSaude = 8000;

                fome = 0;
                saude = 0;
                felicidade = 0;
            }
        }

    }

        

    
}