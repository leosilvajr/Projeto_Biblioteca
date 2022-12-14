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
            var livro = new LivroDto("Implementando Domain-Driven Design", "Vaugh Vernon", "Alta Books");
            Livros.Add(livro);

            livro = new LivroDto("Domain-Driven Design", "Eric Evans", "Alta Books");
            Livros.Add(livro);

            livro = new LivroDto("Redes Guia Prático", "Carlos Morimoto", "Sul Editores");
            Livros.Add(livro);

            livro = new LivroDto("PHP Programando com Orientação Objeto", "Pablo Dall' Ogilo", "Novatec");
            Livros.Add(livro);

            livro = new LivroDto("Introdução a Programação com Python", "Nilo Menezes. E", "Novatec");
            Livros.Add(livro);


        }
    }
}
