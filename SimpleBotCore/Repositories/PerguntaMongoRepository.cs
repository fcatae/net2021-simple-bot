using MongoDB.Bson;
using MongoDB.Driver;
using SimpleBotCore.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBotCore.Repositories
{
    public class PerguntaMongoRepository : IPerguntaMongoRepository
    {   
        private IMongoClient _client;      
        public PerguntaMongoRepository(MongoClient connection)
        {
            _client = connection;
        }
        public void SalvarPergunta(string pergunta, string userId)
        {                  
            var dbm = _client.GetDatabase("dbbot2021");          
            var colperguntas = dbm.GetCollection<PerguntaModel>("colperguntas");           
            var perguntaModel = new PerguntaModel() { UserId = userId, Texto = pergunta };
            colperguntas.InsertOne(perguntaModel);       
        }   
    }
}
