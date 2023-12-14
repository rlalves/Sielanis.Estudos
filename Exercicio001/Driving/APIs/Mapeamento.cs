using System.Text;
using Hexagonal002.Aplication.Aplicacao;
using Hexagonal002.Aplication.Modelo;

namespace Hexagonal002.Driving.APIs
{
    public class Mapeamento
    {
        public void Configurar(WebApplication app)
        {
            app.MapPost("/inserirpessoa", (string nome, int idade) =>
            {
                new PessoaAplicacao().InserirPessoas(new Pessoa(){ Nome = nome, Idade = idade});
                return "Sucesso.";
            })
            .WithName("InserirPessoa")
            .WithOpenApi();

            app.MapGet("/teste", () =>
            {
                return "Sucesso.";
            })
            .WithName("Teste")
            .WithOpenApi();
        }
    }
}
