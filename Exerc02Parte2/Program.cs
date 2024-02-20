using static Exerc02Parte2.LojaVirtual;

namespace Exerc02Parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Loja minhaLojaVirtual = new Loja();

            minhaLojaVirtual.AdicionarProduto("Camiseta", 29.99m);
            minhaLojaVirtual.AdicionarProduto("Calça Jeans", 59.99m);
            minhaLojaVirtual.AdicionarProduto("Tênis", 99.99m);

            minhaLojaVirtual.AdicionarAoCarrinho("Camiseta", 2);
            minhaLojaVirtual.AdicionarAoCarrinho("Tênis", 1);

            minhaLojaVirtual.AplicarDesconto(10); 

            decimal totalCompra = minhaLojaVirtual.CalcularValorTotalCompra();
            Console.WriteLine($"Valor total da compra: {totalCompra:C}");
        }

    }
}