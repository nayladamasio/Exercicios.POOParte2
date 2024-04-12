namespace Exerc09Parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JogoAdivinhacao jogo = new JogoAdivinhacao();

            Console.WriteLine("\n==== Bem-vindo ao Jogo de Adivinhacao! ====");
            Console.WriteLine("\nTente adivinhar o numero entre 1 e 100.");

            while (true)
            {
                Console.Write("\nDigite o seu palpite: ");
                int palpite;
                if (int.TryParse(Console.ReadLine(), out palpite))
                {
                    string resultado = jogo.VerificarPalpite(palpite);
                    Console.WriteLine(resultado);

                    if (resultado.StartsWith("\nParabens!"))
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("\nPor favor, digite um numero valido.");
                }
            }
        }
    }
}
