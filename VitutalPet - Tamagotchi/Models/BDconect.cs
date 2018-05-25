using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using VitutalPet___Tamagotchi.Models;

namespace VitutalPet___Tamagotchi
{
    public class BDconect
    {
        public object Conect()
        {
            var c = new MongoDB.Driver.MongoClient();
            var db = c.GetDatabase("TesteTamagotchi");

            return db;
        }

        public object Get_CollectionUser(IMongoDatabase db)
        {
            var collUser = db.GetCollection<User>("User");
            return collUser;
        }

        public object Get_CollectionTamagotchi(IMongoDatabase db)
        {
            var collTamagotchi = db.GetCollection<Tamagotchi>("Tamagotchi");
            return collTamagotchi;
        }

    }
}