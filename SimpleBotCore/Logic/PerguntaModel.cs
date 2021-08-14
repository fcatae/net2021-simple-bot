using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBotCore.Logic
{
    public class PerguntaModel
    {
        [BsonElement("userId")]
        public string UserId { get; set; }
        [BsonElement("texto")]
        public string Texto { get; set; }
    }
}
