using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc08Parte2
{
    internal class Calendario
    {
        private int ano;
        private List<DateTime> feriados;

        public Calendario(int ano)
        {
            this.ano = ano;
            this.feriados = new List<DateTime>();
            AdicionarFeriadosFixos();
        }

        private void AdicionarFeriadosFixos()
        {
            this.feriados.Add(new DateTime(ano, 1, 1)); // Ano Novo
            this.feriados.Add(new DateTime(ano, 4, 21)); // Tiradentes
            this.feriados.Add(new DateTime(ano, 5, 1)); // Dia do Trabalho
            this.feriados.Add(new DateTime(ano, 9, 7)); // Independência do Brasil
            this.feriados.Add(new DateTime(ano, 10, 12)); // Nossa Senhora Aparecida
            this.feriados.Add(new DateTime(ano, 11, 2)); // Finados
            this.feriados.Add(new DateTime(ano, 11, 15)); // Proclamação da República
            this.feriados.Add(new DateTime(ano, 12, 25)); // Natal
        }
        public void ExibirCalendario(int mes)
        {
            if (mes < 1 || mes > 12)
            {
                Console.WriteLine("Mes invalido. Por favor, escolha um numero de 1 a 12.");
                return;
            }

            DateTime primeiroDiaDoMes = new DateTime(ano, mes, 1);
            int diasNoMes = DateTime.DaysInMonth(ano, mes);

            Console.WriteLine($"Calendario para {primeiroDiaDoMes.ToString("MMMM")} {ano}:");
            Console.WriteLine("Dom Seg Ter Qua Qui Sex Sab");

            for (int i = 0; i < (int)primeiroDiaDoMes.DayOfWeek; i++)
            {
                Console.Write("    ");
            }

            for (int dia = 1; dia <= diasNoMes; dia++)
            {
                if (feriados.Contains(new DateTime(ano, mes, dia)))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.Write($"{dia,3}");

                if (primeiroDiaDoMes.AddDays(dia).DayOfWeek == DayOfWeek.Saturday)
                {
                    Console.WriteLine();
                }

                Console.ResetColor();
            }
            Console.WriteLine();
        }

        public bool VerificarFeriado(DateTime data)
        {
            return feriados.Contains(data.Date);
        }

        public int CalcularDiferencaDias(DateTime data1, DateTime data2)
        {
            TimeSpan diff = data2.Date - data1.Date;
            return Math.Abs(diff.Days);
        }
    }
}