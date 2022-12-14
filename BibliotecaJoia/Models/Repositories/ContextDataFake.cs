using BibliotecaJoia.Models.Dtos;

namespace BibliotecaJoia.Models.Repositories
{
    public static class ContextDataFake
    {
        public static List<LivroDto> Livros;

        //Classe Statica com construtor também statico.
        static ContextDataFake()
        {
            Livros = new List<LivroDto>();

            //Metodo para inicializar o Banco de dados
            InicializeData();
        }

        private static void InicializeData()
        {
            var livro = new LivroDto("01", "Implementando Domain-Driven Design", "Vaugh Vernon", "Alta Books");
            Livros.Add(livro);

            livro = new LivroDto("02", "Domain-Driven Design", "Eric Evans", "Alta Books");
            Livros.Add(livro);

            livro = new LivroDto("03", "Redes Guia Prático", "Carlos Morimoto", "Sul Editores");
            Livros.Add(livro);

            livro = new LivroDto("04", "PHP Programando com Orientação Objeto", "Pablo Dall' Ogilo", "Novatec");
            Livros.Add(livro);

            livro = new LivroDto("05", "Introdução a Programação com Python", "Nilo Menezes. E", "Novatec");
            Livros.Add(livro);


        }
    }
}
