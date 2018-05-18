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
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void BT_dormir(object sender, EventArgs e)
        {
            bool noite = false;
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
    }
}