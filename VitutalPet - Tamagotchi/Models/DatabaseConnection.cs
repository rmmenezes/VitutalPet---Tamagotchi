using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VitutalPet___Tamagotchi.Models;

namespace VitutalPet___Tamagotchi
{
    public class DatabaseConnection
    {
        public IMongoDatabase GetConnection() {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("TesteTamagotchi");
            return database;
        }

        public IMongoCollection<User> GetUserCollection()
        {
            var database = GetConnection();
            var CollectionUser = database.GetCollection<User>("user");
            return CollectionUser;
        }    

        public IMongoCollection<Tamagotchi> GetTamagotchiCollection()
        {
            var database = GetConnection();
            var CollectionTamagotchi = database.GetCollection<Tamagotchi>("tamagotchi");
            return CollectionTamagotchi;
        }
    }
}