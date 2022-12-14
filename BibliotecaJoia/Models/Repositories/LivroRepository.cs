
using BibliotecaJoia.Models.Contracts.Repositories;
using BibliotecaJoia.Models.Dtos;
using BibliotecaJoia.Models.Services;

namespace BibliotecaJoia.Models.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        public void Atualizar(LivroDto livro)
        {
            var objPesquisa = PesquisarPorId(livro.Id);
            ContextDataFake.Livros.Remove(objPesquisa);
            objPesquisa.Nome = livro.Nome;
            objPesquisa.Editora = livro.Editora;
            objPesquisa.Autor = livro.Autor;

            Cadastrar(objPesquisa);
        }

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

        public LivroDto PesquisarPorId(string id)
        {
            //Paramatro onde ID Seja igual ao ID iNFORMADO
            var livro = ContextDataFake.Livros.FirstOrDefault(p => p.Id == id);
            return livro;

        }
    }
}
