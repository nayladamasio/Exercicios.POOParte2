namespace Exerc05Parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao jogo de cartas!");
            Console.WriteLine("\nDigite o numero de jogadores a partir de 2:");
            int numJogadores;
            while (!int.TryParse(Console.ReadLine(), out numJogadores) || numJogadores < 2)
            {
                Console.WriteLine("Numero invalido de jogadores. Por favor, digite um numero maior ou igual a 2:");
            }

            JogoCartas jogo = new JogoCartas(numJogadores);

            Console.WriteLine("\nO jogo começou!");
            while (true)
            {
                for (int i = 0; i < numJogadores; i++)
                {
                    Console.WriteLine($"\nJogador {i + 1}, e a sua vez. Digite o indice da carta que deseja jogar:");
                    for (int j = 0; j < jogo.jogadores[i].Count; j++)
                    {
                        Console.WriteLine($"{j}: {jogo.jogadores[i][j]}");
                    }

                    int cartaIndex;
                    while (!int.TryParse(Console.ReadLine(), out cartaIndex) || cartaIndex < 0 || cartaIndex >= jogo.jogadores[i].Count)
                    {
                        Console.WriteLine("Indice invalido. Por favor, digite um numero valido:");
                    }

                    jogo.JogarCarta(i, jogo.jogadores[i][cartaIndex]);
                    jogo.MostrarMonte();

                    if (jogo.jogadores[i].Count == 0)
                    {
                        Console.WriteLine($"Jogador {i + 1} venceu!");
                        return;
                    }
                }
            }
        }
    }
}