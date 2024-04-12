using static Exerc02Parte2.LojaVirtual;

namespace Exerc02Parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LojaVirtual minhaLoja = new LojaVirtual();

            while (true)
            {
                Console.WriteLine("=== Loja Virtual ===");
                Console.WriteLine("\n1. Cadastrar Produto");
                Console.WriteLine("2. Mostrar Catalogo de Produtos");
                Console.WriteLine("3. Adicionar Item ao Carrinho");
                Console.WriteLine("4. Mostrar Carrinho de Compras");
                Console.WriteLine("5. Aplicar Desconto");
                Console.WriteLine("6. Calcular Valor Total da Compra");
                Console.WriteLine("7. Sair");
                Console.WriteLine("\n====================");
                Console.Write("\nEscolha uma opcao: ");

                string escolha = Console.ReadLine();
                Console.WriteLine();

                switch (escolha)
                {
                    case "1":
                        CadastrarProduto(minhaLoja);
                        break;
                    case "2":
                        minhaLoja.MostrarCatalogo();
                        break;
                    case "3":
                        AdicionarItemCarrinho(minhaLoja);
                        break;
                    case "4":
                        minhaLoja.MostrarCarrinho();
                        break;
                    case "5":
                        AplicarDesconto(minhaLoja);
                        break;
                    case "6":
                        CalcularValorTotalCompra(minhaLoja);
                        break;
                    case "7":
                        Console.WriteLine("Saindo...");
                        return;
                    default:
                        Console.WriteLine("Opcao invalida! Por favor, escolha novamente.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void CadastrarProduto(LojaVirtual loja)
        {
            Console.WriteLine("=== Cadastrar Produto ===");
            Console.Write("\nDigite o nome do produto: ");
            string nome = Console.ReadLine();

            decimal preco;
            while (true)
            {
                Console.Write("\nDigite o preço do produto: ");
                if (decimal.TryParse(Console.ReadLine(), out preco) && preco > 0)
                    break;
                else
                    Console.WriteLine("Por favor, digite um preco valido maior que zero.");
            }

            loja.CadastrarProduto(nome, preco);
            Console.ReadKey();
            Console.Clear();
        }

        static void AdicionarItemCarrinho(LojaVirtual loja)
        {
            Console.WriteLine("=== Adicionar Item ao Carrinho ===");
            loja.MostrarCatalogo();
            Console.Write("\nDigite o nome do produto: ");
            string nomeProduto = Console.ReadLine();

            int quantidade;
            while (true)
            {
                Console.Write("\nDigite a quantidade: ");
                if (int.TryParse(Console.ReadLine(), out quantidade) && quantidade > 0)
                    break;
                else
                    Console.WriteLine("Por favor, digite uma quantidade valida maior que zero.");
            }

            loja.AdicionarAoCarrinho(nomeProduto, quantidade);
        }

        static void AplicarDesconto(LojaVirtual loja)
        {

            decimal percentualDesconto = 10;
            loja.AplicarDesconto(percentualDesconto);
            Console.ReadKey();
            Console.Clear();
        
        }

        static void CalcularValorTotalCompra(LojaVirtual loja)
        {
            decimal totalCompra = loja.CalcularValorTotalCompra();
            Console.WriteLine($"Valor total da compra: {totalCompra:C}");
            Console.ReadKey();
            Console.Clear();
        }
    }
}