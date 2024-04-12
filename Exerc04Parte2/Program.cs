namespace Exerc04Parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaquinaDeVendas maquina = new MaquinaDeVendas();

            Console.WriteLine("-- Maquina de Vendas --");

            Console.WriteLine("\nCadastro de produtos:");
            while (true)
            {
                Console.WriteLine("\nDigite o nome do produto (ou 'sair' para encerrar o cadastro):");
                string nome = Console.ReadLine();
                if (nome.ToLower() == "sair")
                    break;

                Console.WriteLine("\nDigite o preco do produto:");
                decimal preco;
                while (!decimal.TryParse(Console.ReadLine(), out preco) || preco <= 0)
                {
                    Console.WriteLine("Valor invalido. Digite um valor positivo:");
                }

                Console.WriteLine("\nDigite a quantidade em estoque:");
                int quantidade;
                while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade < 0)
                {
                    Console.WriteLine("Valor invalido. Digite uma quantidade nao negativa:");
                }

                maquina.CadastrarProduto(nome, preco, quantidade);
            }

            maquina.ExibirEstoque();

            Console.WriteLine("\nInsira dinheiro na maquina:");
            decimal valorInserido;
            while (true)
            {
                while (!decimal.TryParse(Console.ReadLine(), out valorInserido) || valorInserido < 0)
                {
                    Console.WriteLine("Valor invalido. Digite um valor nao negativo:");
                }

                if (valorInserido == 0)
                    break;

                maquina.InserirDinheiro(valorInserido);
                Console.WriteLine("\nInsira mais dinheiro (ou digite 0 para finalizar):");
            }

            Console.WriteLine("\nDigite o nome do produto para comprar:");
            string produtoSelecionado = Console.ReadLine();
            maquina.SelecionarProduto(produtoSelecionado);

            decimal troco = maquina.RetornarTroco();
            Console.WriteLine($"\nTroco retornado: {troco}");
        }
    }
}
