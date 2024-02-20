using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc02Parte2
{
    internal class LojaVirtual
    {
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

        public class Loja
        {
            private List<Produto> catalogo;
            private Dictionary<Produto, int> carrinho;

            public Loja()
            {
                catalogo = new List<Produto>();
                carrinho = new Dictionary<Produto, int>();
            }

            public void AdicionarProduto(string nome, decimal preco)
            {
                Produto novoProduto = new Produto(nome, preco);
                catalogo.Add(novoProduto);
            }

            internal void AdicionarAoCarrinho(string nomeProduto, int quantidade)
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
                }
                else
                {
                    Console.WriteLine("Produto não encontrado no catálogo.");
                }
            }

            public void AplicarDesconto(decimal percentualDesconto)
            {
                foreach (var item in carrinho)
                {
                    Produto produto = item.Key;
                    decimal novoPreco = produto.Preco - (produto.Preco * percentualDesconto / 100);
                    produto.Preco = novoPreco;
                }
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
        }
    }

}

