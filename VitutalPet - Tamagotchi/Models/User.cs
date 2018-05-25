using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VitutalPet___Tamagotchi.Models
{
    public class User
    {
        public ObjectId Id { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public List<Tamagotchi> List { get; set; }
    }
}