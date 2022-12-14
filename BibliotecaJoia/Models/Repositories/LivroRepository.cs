
using BibliotecaJoia.Models.Contracts.Repositories;
using BibliotecaJoia.Models.Dtos;
using BibliotecaJoia.Models.Services;

namespace BibliotecaJoia.Models.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        public void Cadastrar(LivroDto livro)
        {
            ContextDataFake.Livros.Add(livro);
        }

        public List<LivroDto> Listar()
        {
            //Acessando os dados do Banco Fake
            var livros = ContextDataFake.Livros;

            //Retornando os Dados.
            return livros.OrderBy(p => p.Nome).ToList();
        }
    }
}
