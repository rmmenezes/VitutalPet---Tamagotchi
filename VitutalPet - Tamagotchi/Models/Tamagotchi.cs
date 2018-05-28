using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VitutalPet___Tamagotchi.Models
{
    public class Tamagotchi
    {
        public ObjectId Id { get; set; }
        public String Nome_Tamagotchi { get; set; }
        public String Nome_User { get; set; }
        public String Estado { get; set; }
        public double Fome { get; set; }
        public double Felicidade { get; set; }
        public double Saude { get; set; }
        public double Sono { get; set; }
        public DateTime Tempo { get; set; }
        public String Personagem { get; set; }
    }
}