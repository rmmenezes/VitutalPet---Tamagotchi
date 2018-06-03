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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Btn_Entrar(object sender, EventArgs e)
        {
            String user = username.Text;
            String pass = password.Text;
            var CollectionUser = new DatabaseConnection().GetUserCollection();
            User UserLogged = new User().Verifica(CollectionUser,user,pass);

            if ( UserLogged != null)
            {
                Session["Auth"] = UserLogged.Username;
                Response.Redirect("inicial.aspx");
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }

        public void Btn_Cadastrar(object sender, EventArgs e)
        {
            String user = username.Text;
            String pass = password.Text;
            var NewUser = new User().CreateUser(user, pass);
            if(NewUser == null)
            {
                Response.Write("<script>alert('Hello');</script>");
            }
        }
    }
}