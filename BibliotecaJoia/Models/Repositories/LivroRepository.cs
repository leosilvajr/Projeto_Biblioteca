
using BibliotecaJoia.Models.Contracts.Repositories;
using BibliotecaJoia.Models.Dtos;

namespace BibliotecaJoia.Models.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        public List<LivroDto> Listar()
        {
            //Acessando os dados do Banco Fake
            var livros = ContextDataFake.Livros;

            //Retornando os Dados.
            return livros.OrderBy(p => p.Nome).ToList();
        }
    }
}
