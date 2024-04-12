namespace Exerc07Parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            while (true)
            {
                Console.WriteLine("---- Biblioteca ----");


                Console.WriteLine("\nSelecione uma opcao:");
                Console.WriteLine("\n1 - Cadastrar livro");
                Console.WriteLine("2 - Emprestar livro");
                Console.WriteLine("3 - Devolver livro");
                Console.WriteLine("4 - Verificar disponibilidade de um livro");
                Console.WriteLine("5 - Sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("\nDigite o titulo do livro: ");
                        string titulo = Console.ReadLine();
                        Console.Write("\nDigite o autor do livro: ");
                        string autor = Console.ReadLine();
                        biblioteca.CadastrarLivro(titulo, autor);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Write("\nDigite o titulo do livro a ser emprestado: ");
                        string livroEmprestar = Console.ReadLine();
                        biblioteca.EmprestarLivro(livroEmprestar);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Write("\nDigite o titulo do livro a ser devolvido: ");
                        string livroDevolver = Console.ReadLine();
                        biblioteca.DevolverLivro(livroDevolver);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Write("Digite o titulo do livro para verificar disponibilidade: ");
                        string livroVerificar = Console.ReadLine();
                        biblioteca.VerificarDisponibilidade(livroVerificar);
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case "5":
                        Console.WriteLine("Saindo do programa...");
                        return;
                    default:
                        Console.WriteLine("Opcao invalida!");
                        break;
                }
            }
        }
    }
}