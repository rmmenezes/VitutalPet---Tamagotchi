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
    public partial class Ranking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected List<Tamagotchi> ListarRanking()
        {
            var CollectionTamagotchi = new DatabaseConnection().GetTamagotchiCollection();
            var res = CollectionTamagotchi.Find(x => x.Nivel > -1).ToList().OrderByDescending(s => s.Nivel).ToList();
            if (res.Count() != 0)
            {
                return res;
            }
            else
            {
                return null;
            }
        }

        public string ReturnDado(string t)
        {
            return t;
        }
        public string ReturnCaminho(string t)
        {
            return "/Person/" + t + ".JPG";
        }
        public void Sair(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
        
        public int ReturnNivel(DateTime criacao)
        {
            TimeSpan time = DateTime.Now - criacao;
            int n = (int)time.TotalHours;
            if (n < 0)
            {
                return n * -1;
            }
            else
            {
                return n;
            }
        }
       
    }
}