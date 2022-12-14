using BibliotecaJoia.Models.Dtos;

namespace BibliotecaJoia.Models.Contracts.Services
{
    public interface ILivroService
    {

        void Cadastrar(LivroDto livro);
        List<LivroDto> Listar();
    }
}
