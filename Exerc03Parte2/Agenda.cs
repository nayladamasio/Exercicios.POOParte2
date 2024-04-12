using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc03Parte2
{
    public class Agenda
    {
        private List<Contato> contatos;

        public Agenda()
        {
            contatos = new List<Contato>();
        }

        public void AdicionarContato(string nome, string numeroTelefone)
        {
            Contato novoContato = new Contato(nome, numeroTelefone);
            AdicionarContatoNaLista(novoContato);
        }

        private void AdicionarContatoNaLista(Contato contato)
        {
            contatos.Add(contato);
        }
        public void EditarContato(string nome, string novoNumeroTelefone)
        {
            Contato contato = contatos.FirstOrDefault(c => c.Nome == nome);
            if (contato != null)
            {
                contato.NumeroTelefone = novoNumeroTelefone;
                Console.WriteLine("Contato editado com sucesso.");
            }
            else
            {
                Console.WriteLine("Contato nao encontrado.");
            }
        }
        public void RemoverContato(string nome)
        {
            Contato contato = contatos.FirstOrDefault(c => c.Nome == nome);
            if (contato != null)
            {
                contatos.Remove(contato);
                Console.WriteLine("Contato removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Contato nao encontrado.");
            }
        }

        public void BuscarContatoPorNome(string nome)
        {
            Contato contato = contatos.FirstOrDefault(c => c.Nome == nome);
            if (contato != null)
            {
                Console.WriteLine($"Nome: {contato.Nome}, Telefone: {contato.NumeroTelefone}");
            }
            else
            {
                Console.WriteLine("Contato nao encontrado.");
            }
        }

        public void BuscarContatoPorTelefone(string numeroTelefone)
        {
            Contato contato = contatos.FirstOrDefault(c => c.NumeroTelefone == numeroTelefone);
            if (contato != null)
            {
                Console.WriteLine($"Nome: {contato.Nome}, Telefone: {contato.NumeroTelefone}");
            }
            else
            {
                Console.WriteLine("Contato nao encontrado.");
            }
        }
    }
    public class Contato
    {
        public string Nome { get; set; }
        public string NumeroTelefone { get; set; }

        public Contato(string nome, string numeroTelefone)
        {
            Nome = nome;
            NumeroTelefone = numeroTelefone;
        }
    }
}