using Hexagonal002.Aplication.Modelo;
using Hexagonal002.Driver.Repositorio;

namespace Hexagonal002.Aplication.Aplicacao
{
    public class PessoaAplicacao
    {
        public void InserirPessoas(Pessoa pessoa)
        {
            new PessoaRepositorio().Inserir(pessoa);
        }
    }
}