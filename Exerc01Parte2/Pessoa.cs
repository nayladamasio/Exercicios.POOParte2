using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc01Parte2
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Profissao { get; set; }

        public Pessoa(string nome, int idade, string profissao)
        {
            Nome = nome;
            Idade = idade;
            Profissao = profissao;
        }

        public int CalcularIdadeEmBissextos()
        {
            int idadeEmBissextos = Idade / 4;
            return idadeEmBissextos;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("\nNome: " + Nome);
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine("Profissão: " + Profissao);
        }
    }
}
