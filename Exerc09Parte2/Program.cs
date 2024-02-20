namespace Exerc09Parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JogoAdivinhacao jogo = new JogoAdivinhacao();

            Console.WriteLine("Bem-vindo ao Jogo de Adivinhacao!");
            Console.WriteLine("Tente adivinhar o numero entre 1 e 100.");

            while (true)
            {
                Console.Write("Digite o seu palpite: ");
                int palpite;
                if (int.TryParse(Console.ReadLine(), out palpite))
                {
                    string resultado = jogo.VerificarPalpite(palpite);
                    Console.WriteLine(resultado);

                    if (resultado.StartsWith("Parabens!"))
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, digite um numero valido.");
                }
            }
        }
    }
}
