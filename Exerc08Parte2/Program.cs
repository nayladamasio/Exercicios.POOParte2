namespace Exerc08Parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calendario calendario = new Calendario(2024);

            calendario.ExibirCalendario(2);

            DateTime dataFeriado = new DateTime(2024, 12, 25);
            bool ehFeriado = calendario.VerificarFeriado(dataFeriado);
            Console.WriteLine($"E feriado? {ehFeriado}");

            DateTime data1 = new DateTime(2024, 1, 1);
            DateTime data2 = new DateTime(2024, 12, 31);
            int diferencaDias = calendario.CalcularDiferencaDias(data1, data2);
            Console.WriteLine($"Diferença de dias entre {data1.ToShortDateString()} e {data2.ToShortDateString()}: {diferencaDias}");
        }
    }

}
