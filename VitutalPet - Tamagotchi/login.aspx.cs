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
           //
        }

        public void Btn_Entrar(object sender, EventArgs e)
        {
            String user = username.Text;
            String pass = password.Text;
            
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("TesteTamagotchi");
            var users = database.GetCollection<User>("user");
            var tamagotchis = database.GetCollection<Tamagotchi>("tamagotchi");

            User UserLogged = Verifica(users, user, pass);
            


            if ( UserLogged != null)
            {
                Session["Auth"] = UserLogged.Username;
                Response.Redirect("inicial.aspx");
            }
            else
            {
                //Implementar caso de erro.
            }

        }


        public void Btn_Cadastrar(object sender, EventArgs e)
        {
            String user = username.Text;
            String pass = password.Text;
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("TesteTamagotchi");
            var users = database.GetCollection<User>("user");
            var tamagotchis = database.GetCollection<Tamagotchi>("tamagotchi");

            CreateUser(users, user, pass);
        }


        public void CreateUser(IMongoCollection<User> users, string username, string password)
        {
            User u = new User() { Username = username, Password = password };
            users.InsertOne(u);
        }

        public User Verifica(IMongoCollection<User> users, string username, string password)
        {
            var res = users.Find(x => x.Username == username && x.Password == password);
            if (res.Count() != 0)
            {
                return res.ToList().First();
            }
            else
            {
                return null;
            }
        }


        

    }
}