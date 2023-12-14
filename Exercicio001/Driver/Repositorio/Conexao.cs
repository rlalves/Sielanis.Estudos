using MySqlConnector;

namespace Hexagonal002.Driver.Repositorio
{
    public class Conexao
    {
        const string strConexao = "Server=localhost;Database=Estudos;Uid=root;Pwd=root;";

        public MySqlConnection GetConexao()
        {  
            MySqlConnection conexao = new MySqlConnection(strConexao);
            conexao.Open();
            return conexao;
        }
    }
}