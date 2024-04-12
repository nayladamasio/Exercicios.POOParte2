using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc02Parte2
{
    internal class LojaVirtual
    {
        private List<Produto> catalogo;
        private Dictionary<Produto, int> carrinho;

        public LojaVirtual()
        {
            catalogo = new List<Produto>();
            carrinho = new Dictionary<Produto, int>();
        }

        public void CadastrarProduto(string nome, decimal preco)
        {
            Produto novoProduto = new Produto(nome, preco);
            catalogo.Add(novoProduto);
            Console.WriteLine($"Produto '{nome}' cadastrado com sucesso!");
        }

        public void MostrarCatalogo()
        {
            Console.WriteLine("\n=== Catalogo de Produtos ===");
            foreach (var produto in catalogo)
            {
                Console.WriteLine($"\nNome: {produto.Nome} | Preço: {produto.Preco:C}");
            }
            Console.WriteLine("\n============================");
            
        }

        public void AdicionarAoCarrinho(string nomeProduto, int quantidade)
        {
            Produto produto = catalogo.FirstOrDefault(p => p.Nome == nomeProduto);
            if (produto != null)
            {
                if (carrinho.ContainsKey(produto))
                {
                    carrinho[produto] += quantidade;
                }
                else
                {
                    carrinho.Add(produto, quantidade);
                }
                Console.WriteLine($"Adicionado {quantidade}x '{nomeProduto}' ao carrinho!");
                Console.ReadKey();
                Console.Clear();

            }
            else
            {
                Console.WriteLine("Produto nao encontrado no catalogo.");
               
            }
        }

        public void AplicarDesconto(decimal percentualDesconto)
        {
            foreach (var item in carrinho)
            {
                Produto produto = item.Key;
                decimal precoComDesconto = produto.Preco * (1 - percentualDesconto / 100);
                produto.Preco = precoComDesconto;
            }
            Console.WriteLine($"Desconto de {percentualDesconto}% aplicado com sucesso!");
        }

        public decimal CalcularValorTotalCompra()
        {
            decimal total = 0;
            foreach (var item in carrinho)
            {
                total += item.Key.Preco * item.Value;
            }
            return total;
        }

        public void MostrarCarrinho()
        {
            Console.WriteLine("=== Carrinho de Compras ===");
            foreach (var item in carrinho)
            {
                Console.WriteLine($"\nNome: {item.Key.Nome} | Quantidade: {item.Value} | Preco Unitario: {item.Key.Preco:C} | Preco Total: {(item.Key.Preco * item.Value):C}");
            }
            Console.WriteLine("\n============================");
            Console.ReadKey();
            Console.Clear();
        }
    }

    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}