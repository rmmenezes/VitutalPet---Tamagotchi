using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VitutalPet___Tamagotchi
{
    public partial class tamagotchi : System.Web.UI.Page
    {
        string estado;
        int fome, saude, felicidade, sono;        //indices do pet (definem o estado)
        int txFome, txSaude, txFelicidade, txSono; //taxas de decaimento (muda de acordo com o estado)
        //
        bool noite = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void BT_dormir(object sender, EventArgs e)
        {
            
            if(noite == false)
            {
                background.Attributes["style"] = "background-color: #070317; opacity: 0.2";
                barraSono.Attributes["style"] = "width: 100%;";
                noite = true;
            }
            if(noite == true)
            {
                background.Attributes["style"] = "background-color: #070317; opacity: 1";
                barraSono.Attributes["style"] = "width: 0%;";
                noite = false;
            }


            


        }

        protected void Tamagotchi(object sender, EventArgs e, DateTime lastTime)
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