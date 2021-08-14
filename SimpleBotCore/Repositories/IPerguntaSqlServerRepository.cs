namespace SimpleBotCore.Repositories
{
    public interface IPerguntaSqlServerRepository
    {
       void SalvarPergunta(string pergunta, string userId);
    }
}
