namespace Exerc05Parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JogoCartas jogo = new JogoCartas(3);

            jogo.MostrarMonte();

            jogo.JogarCarta(0, new Carta(CorCarta.Vermelho, TipoCarta.Normal));
            jogo.MostrarMonte();

            jogo.JogarCarta(0, new Carta(CorCarta.Amarelo, TipoCarta.Bloqueio));
            jogo.MostrarMonte();

            jogo.JogarCarta(1, new Carta(CorCarta.Amarelo, TipoCarta.Normal));
            jogo.MostrarMonte();

            Console.ReadLine();
        }
    }
}
