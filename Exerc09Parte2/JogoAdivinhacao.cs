using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc09Parte2
{
    internal class JogoAdivinhacao
    {
        private int numeroAleatorio;
        private Random random;

        public JogoAdivinhacao(int limiteInferior = 1, int limiteSuperior = 100)
        {
            random = new Random();
            numeroAleatorio = random.Next(limiteInferior, limiteSuperior + 1);
        }

        public string VerificarPalpite(int palpite)
        {
            if (palpite == numeroAleatorio)
            {
                return "Parabens! Você acertou o numero.";
            }
            else if (palpite < numeroAleatorio)
            {
                return "O numero e maior que o seu palpite.";
            }
            else
            {
                return "O numero e menor que o seu palpite.";
            }
        }
    }

}
