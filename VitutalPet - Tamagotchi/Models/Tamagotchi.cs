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
        public DateTime Criacao { get; set; }
        public String Personagem { get; set; }
        public int Nivel { get; set; }

        public Tamagotchi CreateTamagotchi(string nome_User, string nome_Tamagotchi, string personagem, int nivel)
        {
            var CollectionTamagotchi = new DatabaseConnection().GetTamagotchiCollection();
            var db = new DatabaseConnection().GetConnection();
            if (ValidaTamagotchi(db, Nome_User, nome_Tamagotchi, personagem) == true)
            {
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
                    Criacao = DateTime.Now,
                    Personagem = personagem,
                    Nivel = nivel,
                };
                CollectionTamagotchi.InsertOne(t);
                return t;
            }
            else
            {
                return null;
            }
        }

        private bool ValidaTamagotchi(IMongoDatabase db ,string nome_User, string nome_Tamagotchi, string personagem)
        {
            if(personagem == "[ Selecione um personagem ]" || nome_Tamagotchi == "")
            {
                return false;
            }else if(Get_tamagotchi(db, nome_User, nome_Tamagotchi) != null){
                return false;
            }
            else 
            {
                return true;
            }
        }

        

        public Tamagotchi Get_tamagotchi(IMongoDatabase database, string nome_UserLogged, string nome_TamagotchiLogged)
        {
            var tamagotchis = database.GetCollection<Tamagotchi>("tamagotchi");
            var res = tamagotchis.Find(x => x.Nome_User == nome_UserLogged && x.Nome_Tamagotchi == nome_TamagotchiLogged);
            if (res.Count() != 0)
            {
                return res.ToList().First();
            }
            else
            {
                return null;
            }
        }

        public List<Tamagotchi> Get_tamagotchi_List(string nome_UserLogged)
        {
            var tamagotchis = new DatabaseConnection().GetTamagotchiCollection();
            var res = tamagotchis.Find(x => x.Nome_User == nome_UserLogged);
            if (res.Count() != 0)
            {
                return res.ToList();
            }
            else
            {
                return null;
            }
        }

        public Tamagotchi Update_Tamagotchi(double fome, double saude, double felicidade, double sono, DateTime lastTime, int nivel ,string estado, Tamagotchi t, IMongoDatabase database)
        {
            var tamagotchis = new DatabaseConnection().GetTamagotchiCollection();
            var filtro = Builders<Tamagotchi>.Filter.Where(x => x.Nome_Tamagotchi == t.Nome_Tamagotchi);
            var change = Builders<Tamagotchi>.Update.Set(x => x.Estado, estado)
                                                    .Set(x => x.Fome, fome)
                                                    .Set(x => x.Saude, saude)
                                                    .Set(x => x.Nivel, nivel)
                                                    .Set(x => x.Felicidade, felicidade)
                                                    .Set(x => x.Sono, sono)
                                                    .Set(x => x.Tempo, lastTime);
            tamagotchis.UpdateOne(filtro, change);
            return t;
        }

      
    }
}