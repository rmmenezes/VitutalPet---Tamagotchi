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
            var UserLogged = Session["Auth"];
            string NomeTamagotchi = nomePet.Text;
            string PersonagemEscolhido = personagem.Text;
            Tamagotchi t = new Tamagotchi().CreateTamagotchi(UserLogged.ToString(), NomeTamagotchi, PersonagemEscolhido, 0);
            Session["Personagem"] = personagem.Text;
            Response.Redirect("tamagotchi.aspx");
        }

        protected void SelectPersonagem(object sender, ImageClickEventArgs e)
        {
            var imageButton = sender as ImageButton;

            if (imageButton.ID == "homer")
            {
                homer.BorderStyle = BorderStyle.Dashed;
                bart.BorderStyle = BorderStyle.None;
                lisa.BorderStyle = BorderStyle.None;
                maggie.BorderStyle = BorderStyle.None;
                marge.BorderStyle = BorderStyle.None;
                ned.BorderStyle = BorderStyle.None;
                personagem.Text = "Homer";
            }
            else if (imageButton.ID == "bart")
            {
                personagem.Text = "Bart";
                homer.BorderStyle = BorderStyle.None;
                bart.BorderStyle = BorderStyle.Dashed;
                lisa.BorderStyle = BorderStyle.None;
                maggie.BorderStyle = BorderStyle.None;
                marge.BorderStyle = BorderStyle.None;
                ned.BorderStyle = BorderStyle.None;
            }
            else if (imageButton.ID == "lisa")
            {
                personagem.Text = "Lisa";
                homer.BorderStyle = BorderStyle.None;
                bart.BorderStyle = BorderStyle.None;
                lisa.BorderStyle = BorderStyle.Dashed;
                maggie.BorderStyle = BorderStyle.None;
                marge.BorderStyle = BorderStyle.None;
                ned.BorderStyle = BorderStyle.None;
            }
            else if (imageButton.ID == "maggie")
            {
                personagem.Text = "Maggie";
                homer.BorderStyle = BorderStyle.None;
                bart.BorderStyle = BorderStyle.None;
                lisa.BorderStyle = BorderStyle.None;
                maggie.BorderStyle = BorderStyle.Dashed;
                marge.BorderStyle = BorderStyle.None;
                ned.BorderStyle = BorderStyle.None;
            }
            else if (imageButton.ID == "marge")
            {
                personagem.Text = "Marge";
                homer.BorderStyle = BorderStyle.None;
                bart.BorderStyle = BorderStyle.None;
                lisa.BorderStyle = BorderStyle.None;
                maggie.BorderStyle = BorderStyle.None;
                marge.BorderStyle = BorderStyle.Dashed;
                ned.BorderStyle = BorderStyle.None;
            }
            else if (imageButton.ID == "ned")
            {
                personagem.Text = "Ned";
                homer.BorderStyle = BorderStyle.None;
                bart.BorderStyle = BorderStyle.None;
                lisa.BorderStyle = BorderStyle.None;
                maggie.BorderStyle = BorderStyle.None;
                marge.BorderStyle = BorderStyle.None;
                ned.BorderStyle = BorderStyle.Dashed;
            }
        }



        protected List<Tamagotchi> Ranking()
        {
            var CollectionTamagotchi = new DatabaseConnection().GetTamagotchiCollection();
            var res = CollectionTamagotchi.Find(x => x.Nome_User == Session["Auth"].ToString()).ToList().OrderByDescending(s => s.Nivel).ToList();
            if (res.Count() != 0)
            {
                return res ;
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
    }
}