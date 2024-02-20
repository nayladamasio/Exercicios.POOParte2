using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc03Parte2
{
    internal class Agenda
    {
            private List<Contato> contatos = new List<Contato>();

        public void AdicionarContato(string nome, string numeroTelefone)
        {
            Contato novoContato = new Contato { Nome = nome, NumeroTelefone = numeroTelefone };
            contatos.Add(novoContato);
        }

        public void EditarContato(string nome, string novoNumeroTelefone)
        {
            Contato contato = contatos.Find(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if (contato != null)
            {
                contato.NumeroTelefone = novoNumeroTelefone;
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }
        }


        class Contato
        {
            public string Nome { get; set; }
            public string NumeroTelefone { get; set; }
        }

       
            public void RemoverContato(string nome)
            {
                Contato contato = contatos.Find(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
                if (contato != null)
                {
                    contatos.Remove(contato);
                }
                else
                {
                    Console.WriteLine("Contato não encontrado.");
                }
            }

            public void BuscarContatoPorNome(string nome)
            {
                Contato contato = contatos.Find(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
                if (contato != null)
                {
                    Console.WriteLine($"Nome: {contato.Nome}, Telefone: {contato.NumeroTelefone}");
                }
                else
                {
                    Console.WriteLine("Contato não encontrado.");
                }
            }

            public void BuscarContatoPorNumeroTelefone(string numeroTelefone)
            {
                Contato contato = contatos.Find(c => c.NumeroTelefone.Equals(numeroTelefone));
                if (contato != null)
                {
                    Console.WriteLine($"Nome: {contato.Nome}, Telefone: {contato.NumeroTelefone}");
                }
                else
                {
                    Console.WriteLine("Contato não encontrado.");
                }
            }
        }


    }

