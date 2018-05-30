using MongoDB.Bson;
using MongoDB.Driver;
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

        public Tamagotchi CreateTamagotchi(string nome_User, string nome_Tamagotchi, string personagem)
        {
            var CollectionTamagotchi = new DatabaseConnection().GetTamagotchiCollection();
            Tamagotchi t = new Tamagotchi()
            {
                Nome_User = nome_User,
                Nome_Tamagotchi = nome_Tamagotchi,
                Saude = 100.00,
                Sono = 100.00,
                Fome = 100.00,
                Felicidade = 100.00,
                Estado = "normal",
                Tempo = DateTime.Now,
                Personagem = personagem
            };
            CollectionTamagotchi.InsertOne(t);
            return t;
        }

        public Tamagotchi Get_tamagotchi(IMongoDatabase database, string nome_UserLogged)
        {
            var tamagotchis = database.GetCollection<Tamagotchi>("tamagotchi");
            var res = tamagotchis.Find(x => x.Nome_User == nome_UserLogged);
            if (res.Count() != 0)
            {
                return res.ToList().First();
            }
            else
            {
                return null;
            }
        }

        public Tamagotchi Update_Tamagotchi(double fome, double saude, double felicidade, double sono, DateTime lastTime, string estado, Tamagotchi t, IMongoDatabase database)
        {
            var tamagotchis = new DatabaseConnection().GetTamagotchiCollection();
            var filtro = Builders<Tamagotchi>.Filter.Where(x => x.Nome_Tamagotchi == t.Nome_Tamagotchi);
            var change = Builders<Tamagotchi>.Update.Set(x => x.Estado, estado)
                                                    .Set(x => x.Fome, fome)
                                                    .Set(x => x.Saude, saude)
                                                    .Set(x => x.Felicidade, felicidade)
                                                    .Set(x => x.Sono, sono)
                                                    .Set(x => x.Tempo, lastTime);
            tamagotchis.UpdateOne(filtro, change);
            return t;
        }

    }
}