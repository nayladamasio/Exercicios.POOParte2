namespace Exerc07Parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            biblioteca.CadastrarLivro("Harry Potter e as Relíquias da Morte", "J.K. Rowling");
            biblioteca.CadastrarLivro("O Pequeno Príncipe", "Antoine de Saint-Exupéry");

            biblioteca.EmprestarLivro("Harry Potter e as Relíquias da Morte");

            biblioteca.VerificarDisponibilidade("Harry Potter e as Relíquias da Morte");
            biblioteca.VerificarDisponibilidade("O Pequeno Príncipe");

            biblioteca.DevolverLivro("Harry Potter e as Relíquias da Morte");

            biblioteca.VerificarDisponibilidade("Harry Potter e as Relíquias da Morte");
        }
    }
}
