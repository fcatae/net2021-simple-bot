using SimpleBotCore.Logic;
using System.Collections.Generic;
using System.Threading;

namespace SimpleBotCore.Repositories
{
    public class PerguntaMockRepository : IPerguntaMockRepository
    {
        private List<PerguntaModel> PerguntaModel { get; set; } = new List<PerguntaModel>();
        public bool SalvarPergunta(string pergunta, string userId)
        {
            PerguntaModel.Add(new PerguntaModel { UserId = userId, Texto = pergunta });
            Thread.Sleep(3);
            return true;
        }
    }
}