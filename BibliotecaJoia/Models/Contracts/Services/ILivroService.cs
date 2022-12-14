using BibliotecaJoia.Models.Dtos;

namespace BibliotecaJoia.Models.Contracts.Services
{
    public interface ILivroService
    {
        List<LivroDto> Listar();
    }
}
