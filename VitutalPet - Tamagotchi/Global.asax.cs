using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace VitutalPet___Tamagotchi
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
        }

        protected void Tamagotchi(object sender, EventArgs e)
        {
            int felicidade = 100, fome = 0, vida = 100;
            string estado = "vivo";

            while (vida > 0)
            {

                if (felicidade < 25)
                {
                    estado = "triste";
                }
                if (fome < 25)
                {
                    estado = "faminto";
                }
                if (vida < 25)
                {
                    estado = "morrendo";
                }

                DateTime data = DateTime.Now;
                
            }

        }
        }
    }