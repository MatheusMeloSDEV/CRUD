using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Repositorio
    {
        private IMongoCollection<Agenda> _agenda;

        public List<Agenda> ListaAgenda
        {
            get
            {
                var filter = Builders<Agenda>.Filter.Empty;
                return _agenda.Find<Agenda>(filter).ToList<Agenda>();
            }
        }

        public Repositorio()
        {
            var mongoClient = new MongoClient("mongodb+srv://guilherme218614:coxinha123@todoapp.d1y3kvy.mongodb.net/");
            var mongoDatabase = mongoClient.GetDatabase("CRUD");
            _agenda = mongoDatabase.GetCollection<Agenda>("agendaDB");

        }
    }
}
