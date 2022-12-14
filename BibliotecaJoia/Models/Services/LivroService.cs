using BibliotecaJoia.Models.Contracts.Repositories;
using BibliotecaJoia.Models.Contracts.Services;
using BibliotecaJoia.Models.Dtos;

namespace BibliotecaJoia.Models.Services
{
    public class LivroService : ILivroService
    {
        //Objeto de Leitura do Repositorio
        private readonly ILivroRepository _livroRepository;


        //Construtor vai receber uma injeção de dependecia do repositorio
        public LivroService(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public void Cadastrar(LivroDto livro)
        {
            try
            {
                _livroRepository.Cadastrar(livro);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<LivroDto> Listar()
        {
            try
            {
                return _livroRepository.Listar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
