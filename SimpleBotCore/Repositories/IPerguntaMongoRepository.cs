namespace SimpleBotCore.Repositories
{
    public interface IPerguntaMongoRepository
    {
        void SalvarPergunta(string pergunta, string id);
    }
}
