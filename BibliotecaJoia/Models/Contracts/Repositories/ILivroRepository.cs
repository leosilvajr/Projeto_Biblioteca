using BibliotecaJoia.Models.Dtos;

namespace BibliotecaJoia.Models.Contracts.Repositories
{
    public interface ILivroRepository
    {
        void Cadastrar(LivroDto livro);
        List<LivroDto> Listar();
    }
}
