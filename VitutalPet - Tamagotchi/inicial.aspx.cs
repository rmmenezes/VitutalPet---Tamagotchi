using MongoDB.Bson;
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
    public partial class inicial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bemvindo.Text = "Bem Vindo " + Session["Auth"].ToString();
        }

        public void Tamagotchiadd(object sender, EventArgs e)
        {
            string nome = nomePet.Text;
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("TesteTamagotchi");
            var users = database.GetCollection<User>("user");
            var tam = database.GetCollection<Tamagotchi>("tamagotchi");

            var UserLogged = Session["Auth"];
            
            Tamagotchi t = CreateTamagotchi(tam, nome, UserLogged.ToString());

            Response.Redirect("tamagotchi.aspx");
        }

        public void HomerSelect(object sender, EventArgs e)
        {
            Btn_homer.BackColor = System.Drawing.Color.Red;
        }

        private Tamagotchi CreateTamagotchi(IMongoCollection<Tamagotchi> tam, string nome, string nome_User)
        {
            Tamagotchi t = new Tamagotchi();

            t.Nome_User = nome_User;
            t.Nome_Tamagotchi = nome;
            t.Saude = 100;
            t.Sono = 0;
            t.Felicidade = 100;
            t.Estado = "normal";
            t.Tempo = DateTime.Now;

            //insere na minha collection (tabela) -> tamagotchi 
            tam.InsertOne(t);

            return t;
        }
    }
}