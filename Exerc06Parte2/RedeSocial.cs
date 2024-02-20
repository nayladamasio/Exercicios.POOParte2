using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc06Parte2
{
    internal class RedeSocial
    {
        private Dictionary<string, List<string>> amigos;
        private Dictionary<string, List<string>> posts;
        public RedeSocial()
        {
            amigos = new Dictionary<string, List<string>>();
            posts = new Dictionary<string, List<string>>();
        }
        public void AdicionarAmigo(string usuario, string amigo)
        {
            if (!amigos.ContainsKey(usuario))
                amigos[usuario] = new List<string>();

            amigos[usuario].Add(amigo);
        }
        public void PublicarMensagem(string usuario, string mensagem)
        {
            if (!posts.ContainsKey(usuario))
                posts[usuario] = new List<string>();

            posts[usuario].Add(mensagem);
        }
        public void ComentarEmPost(string usuario, string autorPost, string comentario)
        {
            if (!posts.ContainsKey(autorPost))
            {
                Console.WriteLine($"Post de {autorPost} não encontrado.");
                return;
            }

            posts[autorPost].Add($"Comentário de {usuario}: {comentario}");
        }

        public List<string> BuscarUsuario(string usuario)
        {
            if (amigos.ContainsKey(usuario))
            {
                return amigos[usuario];
            }
            else
            {
                Console.WriteLine($"Usuário '{usuario}' não encontrado.");
                return new List<string>();
            }
        }
    }
}
