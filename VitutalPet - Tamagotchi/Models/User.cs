using MongoDB.Bson;
using MongoDB.Driver;
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

        public User CreateUser(string nome, string password)
        {
            if(nome == "" && password == "") { return null; }
            var CollectionUser = new DatabaseConnection().GetUserCollection();
            User u = new User
            {
                Username = nome,
                Password = password
            };
            if (NuncaLogado(CollectionUser, nome, password))
            {
                CollectionUser.InsertOne(u);
                return u;
            }
            else
            {
                return null;
            }
        }

        public bool NuncaLogado(IMongoCollection<User> CollectionUser ,string nome, string password)
        {
            if( Verifica(CollectionUser, nome, password) == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public User Verifica(IMongoCollection<User> users, string username, string password)
        {
            var res = users.Find(x => x.Username == username && x.Password == password);
            if (res.Count() != 0)
            {
                return res.ToList().First();
            }
            else
            {
                return null;
            }
        }
    }
}