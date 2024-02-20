namespace Exerc06Parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RedeSocial RedeSocial1 = new RedeSocial();

            RedeSocial1.AdicionarAmigo("Ana", "Bia");
            RedeSocial1.AdicionarAmigo("Ana", "Mateus");

            RedeSocial1.PublicarMensagem("Ana", "Oi, Pessoal.");

            RedeSocial1.PublicarMensagem("Bia", "Oi Ana, saudades.");
            RedeSocial1.PublicarMensagem("Mateus", "Olá, tudo bem?");

            RedeSocial1.ComentarEmPost("Ana", "Bia", "Saudades Bia!");

            RedeSocial1.ComentarEmPost("Mateus", "Ana", "Saudades tambem!");

            List<string> amigosDeAna = RedeSocial1.BuscarUsuario("Ana");
            Console.WriteLine("Amigos de Ana:");
            foreach (var amigo in amigosDeAna)
            {
                Console.WriteLine(amigo);
            }
        }
    }
}
