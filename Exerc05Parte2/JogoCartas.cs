using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc05Parte2
{
    public enum CorCarta
    {
        Vermelho,
        Amarelo,
        Verde,
        Azul
    }
    public enum TipoCarta
    {
        Normal,
        Bloqueio,
        InverterSentido,
        MaisDois
    }

    public class Carta
    {
        public CorCarta Cor { get; set; }
        public TipoCarta Tipo { get; set; }

        public Carta(CorCarta cor, TipoCarta tipo)
        {
            Cor = cor;
            Tipo = tipo;
        }

        public override string ToString()
        {
            return $"{Cor} - {Tipo}";
        }
    }

    public class JogoCartas
    {
        private List<Carta> baralho;
        private Queue<Carta> monte;
        public List<List<Carta>> jogadores;

        public JogoCartas(int numJogadores)
        {
            baralho = CriarBaralho();
            Embaralhar(baralho);
            monte = new Queue<Carta>();
            jogadores = new List<List<Carta>>();

            for (int i = 0; i < numJogadores; i++)
            {
                jogadores.Add(new List<Carta>());
            }

            DistribuirCartas();
        }

        private List<Carta> CriarBaralho()
        {
            List<Carta> novoBaralho = new List<Carta>();

            foreach (CorCarta cor in Enum.GetValues(typeof(CorCarta)))
            {
                foreach (TipoCarta tipo in Enum.GetValues(typeof(TipoCarta)))
                {
                    if (tipo != TipoCarta.Normal)
                    {
                        novoBaralho.Add(new Carta(cor, tipo));
                        novoBaralho.Add(new Carta(cor, tipo));
                    }
                    else
                    {
                        novoBaralho.Add(new Carta(cor, tipo));
                    }
                }
            }

            return novoBaralho;
        }

        private void Embaralhar(List<Carta> cartas)
        {
            Random rng = new Random();
            int n = cartas.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Carta value = cartas[k];
                cartas[k] = cartas[n];
                cartas[n] = value;
            }
        }

        private void DistribuirCartas()
        {
            for (int i = 0; i < 7; i++)
            {
                foreach (var jogador in jogadores)
                {
                    jogador.Add(baralho.First());
                    baralho.RemoveAt(0);
                }
            }

            monte.Enqueue(baralho.First());
            baralho.RemoveAt(0);
        }

        public void JogarCarta(int jogadorIndex, Carta carta)
        {
            var jogador = jogadores[jogadorIndex];
            if (jogador.Contains(carta))
            {
                jogador.Remove(carta);
                monte.Enqueue(carta);
                Console.WriteLine($"Jogador {jogadorIndex + 1} jogou a carta: {carta}");
            }
            else
            {
                Console.WriteLine($"Jogador {jogadorIndex + 1} nao tem essa carta.");
            }
        }

        public void MostrarMonte()
        {
            Console.WriteLine("Cartas no monte:");
            foreach (var carta in monte)
            {
                Console.WriteLine(carta);
            }
        }
    }

}