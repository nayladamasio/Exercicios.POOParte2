using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc01Parte2
{
    internal class Pessoa
    {
        private string nome;
        private int idade;
        private string profissao;

        public Pessoa(string nome, int idade, string profissao)
        {
            this.nome = nome;
            this.idade = idade;
            this.profissao = profissao;
        }

        public int CalcularIdadeEmBissextos()
        {
            int idadeEmBissextos = idade / 4;
            return idadeEmBissextos;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Profissão: " + profissao);
        }
    }
}
