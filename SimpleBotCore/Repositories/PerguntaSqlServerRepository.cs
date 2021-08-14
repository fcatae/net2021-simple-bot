using Dapper;
using SimpleBotCore.Logic;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace SimpleBotCore.Repositories
{
    public class PerguntaSqlServerRepository : IPerguntaSqlServerRepository
    {
        private readonly string _connectionStringSql;
        public PerguntaSqlServerRepository(string connectionString)
        {
            _connectionStringSql = connectionString;
        }
        public void SalvarPergunta(string pergunta, string userId)
        {
            var perguntaModel = new PerguntaModel { UserId = userId, Texto = pergunta };
            using (var con = new SqlConnection(_connectionStringSql))
            {
                var query = @"INSERT INTO Pergunta(userId, texto) VALUES(@UserId, @Texto); ";
                con.Execute(query, perguntaModel);
            }
        }
    }
}