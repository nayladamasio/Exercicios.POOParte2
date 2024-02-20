using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc07Parte2
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public bool Disponivel { get; set; }
    }
    internal class Biblioteca
    {
        private List<Livro> livros = new List<Livro>();

        public void CadastrarLivro(string titulo, string autor)
        {
            Livro livro = new Livro
            {
                Titulo = titulo,
                Autor = autor,
                Disponivel = true
            };
            livros.Add(livro);
            Console.WriteLine("Livro cadastrado com sucesso!");
        }

        public void EmprestarLivro(string titulo)
        {
            Livro livro = livros.Find(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (livro != null && livro.Disponivel)
            {
                livro.Disponivel = false;
                Console.WriteLine("Livro emprestado com sucesso!");
            }
            else
            {
                Console.WriteLine("Livro nao disponivel para emprestimo.");
            }
        }

        public void DevolverLivro(string titulo)
        {
            Livro livro = livros.Find(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (livro != null && !livro.Disponivel)
            {
                livro.Disponivel = true;
                Console.WriteLine("Livro devolvido com sucesso!");
            }
            else
            {
                Console.WriteLine("Livro nao foi emprestado ou nao pertence a biblioteca.");
            }
        }

        public void VerificarDisponibilidade(string titulo)
        {
            Livro livro = livros.Find(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (livro != null)
            {
                if (livro.Disponivel)
                {
                    Console.WriteLine("O livro esta disponivel para emprestimo.");
                }
                else
                {
                    Console.WriteLine("O livro nao esta disponivel para emprestimo.");
                }
            }
            else
            {
                Console.WriteLine("Livro nao encontrado na biblioteca.");
            }
        }
    }

}
