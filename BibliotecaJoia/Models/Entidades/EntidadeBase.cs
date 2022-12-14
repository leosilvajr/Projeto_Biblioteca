namespace BibliotecaJoia.Models.Entidades
{
    //Classe para Gerar os ID dos Livros
    public abstract class EntidadeBase
    {
        public string Id { get; set; }

        public EntidadeBase()
        {
            //Gerar identificador UNICO
            Id = Guid.NewGuid().ToString();
        }
    }
}
