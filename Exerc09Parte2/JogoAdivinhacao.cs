using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc09Parte2
{
    internal class JogoAdivinhacao
    {
        private int NumeroAleatorio;
        private Random random;

        public JogoAdivinhacao(int limiteInferior = 1, int limiteSuperior = 100)
        {
            random = new Random();
            NumeroAleatorio = random.Next(limiteInferior, limiteSuperior + 1);
        }

        public string VerificarPalpite(int palpite)
        {
            if (palpite == NumeroAleatorio)
            {
                return "\nParabens! Você acertou o numero.";
            }
            else if (palpite < NumeroAleatorio)
            {
                return "\nO numero e maior que o seu palpite.";
            }
            else
            {
                return "\nO numero e menor que o seu palpite.";
            }
        }
    }

}
