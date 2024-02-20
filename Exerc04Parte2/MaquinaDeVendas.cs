using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc04Parte2
{
    internal class MaquinaDeVendas
    {
        public class Produto
        {
            public string Nome { get; set; }
            public decimal Preco { get; set; }
            public int Quantidade { get; set; }
        }

        private List<Produto> estoque;
        private decimal saldo;

        public MaquinaDeVendas()
        {
            estoque = new List<Produto>();
            saldo = 0;
        }

        public void CadastrarProduto(string nome, decimal preco, int quantidade)
        {
            Produto produto = new Produto
            {
                Nome = nome,
                Preco = preco,
                Quantidade = quantidade
            };
            estoque.Add(produto);
        }

        public void ExibirEstoque()
        {
            Console.WriteLine("Estoque disponivel:");
            foreach (var produto in estoque)
            {
                Console.WriteLine($"Produto: {produto.Nome}, Preco: {produto.Preco}, Quantidade: {produto.Quantidade}");
            }
        }
        public void InserirDinheiro(decimal valor)
        {
            saldo += valor;
            Console.WriteLine($"Saldo atual: {saldo}");
        }

        public void SelecionarProduto(string nome)
        {
            Produto produtoSelecionado = estoque.Find(p => p.Nome == nome);
            if (produtoSelecionado != null && produtoSelecionado.Quantidade > 0 && saldo >= produtoSelecionado.Preco)
            {
                saldo -= produtoSelecionado.Preco;
                produtoSelecionado.Quantidade--;
                Console.WriteLine($"Compra realizada: {produtoSelecionado.Nome}");
                Console.WriteLine($"Troco: {saldo}");
            }
            else
            {
                Console.WriteLine("Produto nao disponivel ou saldo insuficiente.");
            }
        }

        public decimal RetornarTroco()
        {
            decimal troco = saldo;
            saldo = 0;
            return troco;
        }


    }

  




}