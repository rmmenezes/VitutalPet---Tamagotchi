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

        }

        public void Tamagotchiadd(object sender, EventArgs e)
        {
            string nome = nomePet.Text;
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("TesteTamagotchi");
            var users = database.GetCollection<User>("user");
            var tam = database.GetCollection<Tamagotchi>("tamagotchi");

            Tamagotchi t = CreateTamagotchi(tam, nome);
            Response.Redirect("tamagotchi.aspx");
        }

        private Tamagotchi CreateTamagotchi(IMongoCollection<Tamagotchi> tam, string nome)
        {
            Tamagotchi t = new Tamagotchi();

            t.Nome = nome;
            t.Saude = 100;
            t.Sono = 0;
            t.Felicidade = 100;
            t.Estado = "normal";
            t.Tempo = DateTime.Now;
            tam.InsertOneAsync(t);
            return t;
        }
    }
}