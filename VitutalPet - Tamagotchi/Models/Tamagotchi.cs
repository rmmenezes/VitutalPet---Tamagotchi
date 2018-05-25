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
        public int Fome { get; set; }
        public int Felicidade { get; set; }
        public int Saude { get; set; }
        public int Sono { get; set; }
        public DateTime Tempo { get; set; }
    }
}