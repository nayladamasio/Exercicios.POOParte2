namespace Exerc06Parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RedeSocial RedeSocial1 = new RedeSocial();
            string usuario;

            Console.WriteLine("-- Rede Social C# --");

            do
            {
                Console.WriteLine("\nAdicione alguns amigos (digite 'fim' para parar):");
                Console.Write("\nUsuario: ");
                usuario = Console.ReadLine();

                if (usuario.ToLower() != "fim")
                {
                    Console.Write("\nAmigo: ");
                    string amigo = Console.ReadLine();

                    RedeSocial1.AdicionarAmigo(usuario, amigo);
                }
            } while (usuario.ToLower() != "fim");
            Console.ReadKey();
            Console.Clear();

            do
            {
                Console.WriteLine("\nPublicar mensagens (digite 'fim' para parar):");
                Console.Write("\nUsuario: ");
                usuario = Console.ReadLine();

                if (usuario.ToLower() != "fim")
                {
                    Console.Write("\nMensagem: ");
                    string mensagem = Console.ReadLine();

                    RedeSocial1.PublicarMensagem(usuario, mensagem);
                }
            } while (usuario.ToLower() != "fim");
            Console.ReadKey();
            Console.Clear();

            do
            {
                Console.WriteLine("\nComentar em posts (digite 'fim' para parar):");
                Console.Write("\nUsuario: ");
                usuario = Console.ReadLine();

                if (usuario.ToLower() != "fim")
                {
                    Console.Write("\nAutor do post: ");
                    string autorPost = Console.ReadLine();

                    Console.Write("\nComentario: ");
                    string comentario = Console.ReadLine();

                    RedeSocial1.ComentarEmPost(usuario, autorPost, comentario);
                }
            } while (usuario.ToLower() != "fim");
            Console.ReadKey();
            Console.Clear();

            do
            {
                Console.WriteLine("\nBuscar usuarios (digite 'fim' para parar):");
                Console.Write("\nUsuario: ");
                usuario = Console.ReadLine();

                if (usuario.ToLower() != "fim")
                {
                    List<string> amigosDeUsuario = RedeSocial1.BuscarUsuario(usuario);
                    Console.WriteLine($"Amigos de {usuario}:");
                    foreach (var amigo in amigosDeUsuario)
                    {
                        Console.WriteLine(amigo);
                    }
                }
            } while (usuario.ToLower() != "fim");
            Console.ReadKey();
            Console.Clear();
        }
    }
}