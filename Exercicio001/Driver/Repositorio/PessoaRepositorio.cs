using MySqlConnector;
using Hexagonal002.Aplication.Modelo;

namespace Hexagonal002.Driver.Repositorio
{
    public class PessoaRepositorio
    {
        public PessoaRepositorio()
        {

        }

        public void Inserir(Pessoa pessoa)
        {
            Console.WriteLine("Até aqui tudo bem");

            try
            {
                using MySqlConnection conexao = new Conexao().GetConexao();
                using MySqlCommand comando = new MySqlCommand("INSERT INTO pessoa (nome, idade) VALUES (@Nome, @Idade)", conexao);
                comando.Parameters.AddWithValue("@Nome", pessoa.Nome);
                comando.Parameters.AddWithValue("@Idade", pessoa.Idade);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}