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
            Tamagotchi t = new Tamagotchi().CreateTamagotchi(UserLogged.ToString(), NomeTamagotchi, PersonagemEscolhido);
            Session["Personagem"] = personagem.Text;
            Response.Redirect("tamagotchi.aspx");
        }
     
        protected void SelectPersonagem(object sender, ImageClickEventArgs e)
        {
            var imageButton = sender as ImageButton;

            if (imageButton.ID == "homer")
            {
                personagem.Text = "Homer";
            }
            else if (imageButton.ID == "bart")
            {
                personagem.Text = "Bart";
            }
            else if (imageButton.ID == "lisa")
            {
                personagem.Text = "Lisa";
            }
            else if (imageButton.ID == "maggie")
            {
                personagem.Text = "Maggie";
            }
            else if (imageButton.ID == "marge")
            {
                personagem.Text = "Marge";
            }
            else if (imageButton.ID == "ned")
            {
                personagem.Text = "Ned";
            }
        }
    }
}