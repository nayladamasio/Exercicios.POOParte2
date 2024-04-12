namespace Exerc03Parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();

            while (true)
            {
                Console.WriteLine("\n=== Agenda Telefonica ===");
                Console.WriteLine("\n1. Adicionar Contato");
                Console.WriteLine("2. Editar Contato");
                Console.WriteLine("3. Remover Contato");
                Console.WriteLine("4. Buscar Contato por Nome");
                Console.WriteLine("5. Buscar Contato por Telefone");
                Console.WriteLine("6. Sair");
                Console.Write("\nEscolha uma opcao: ");

                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Console.Write("\nDigite o nome do contato: ");
                        string nome = Console.ReadLine();
                        Console.Write("\nDigite o numero de telefone: ");
                        string telefone = Console.ReadLine();
                        agenda.AdicionarContato(nome, telefone);
                        Console.WriteLine("\nContato adicionado com sucesso.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Write("\nDigite o nome do contato a ser editado: ");
                        string nomeEditar = Console.ReadLine();
                        Console.Write("\nDigite o novo numero de telefone: ");
                        string novoTelefone = Console.ReadLine();
                        agenda.EditarContato(nomeEditar, novoTelefone);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Write("\nDigite o nome do contato a ser removido: ");
                        string nomeRemover = Console.ReadLine();
                        agenda.RemoverContato(nomeRemover);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Write("\nDigite o nome do contato a ser buscado: ");
                        string nomeBuscar = Console.ReadLine();
                        agenda.BuscarContatoPorNome(nomeBuscar);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "5":
                        Console.Write("\nDigite o numero de telefone a ser buscado: ");
                        string telefoneBuscar = Console.ReadLine();
                        agenda.BuscarContatoPorTelefone(telefoneBuscar);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "6":
                        Console.WriteLine("\nSaindo...");
                        Console.ReadKey();
                        return;
                    default:
                        Console.WriteLine("\nOpção invalida. Por favor, escolha novamente.");
                        break;
                }
            }
        }
    }
}
