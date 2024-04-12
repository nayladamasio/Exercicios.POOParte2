namespace Exerc08Parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Calendario Anual ----");


            Console.WriteLine("\nDigite o ano para o qual deseja visualizar o calendario:");
            int ano;
            while (!int.TryParse(Console.ReadLine(), out ano) || ano < 1)
            {
                Console.WriteLine("Ano invalido. Por favor, digite um ano valido:");
            }

            Calendario calendario = new Calendario(ano);

            Console.WriteLine("\nDigite o numero do mes para exibir o calendario:");
            int mes;
            while (!int.TryParse(Console.ReadLine(), out mes) || mes < 1 || mes > 12)
            {
                Console.WriteLine("Mas invalido. Por favor, digite um numero de mes valido (1 a 12):");
            }

            calendario.ExibirCalendario(mes);

            Console.WriteLine("\nDigite uma data para verificar se e feriado (no formato DD/MM/AAAA):");
            DateTime data;
            while (!DateTime.TryParse(Console.ReadLine(), out data))
            {
                Console.WriteLine("Formato de data invalido. Por favor, digite uma data valida no formato DD/MM/AAAA:");
            }

            string ehFeriado = calendario.VerificarFeriado(data);
            Console.WriteLine($"\nA data {data.ToShortDateString()} e feriado? {ehFeriado}");

            Console.WriteLine("\nDigite duas datas para calcular a diferenca de dias no formato (DD/MM/AAAA):");

            DateTime data1, data2;
            Console.Write("\nData 1: ");
            while (!DateTime.TryParse(Console.ReadLine(), out data1))
            {
                Console.WriteLine("Formato de data invalido. Por favor, digite uma data valida no formato DD/MM/AAAA:");
            }

            Console.Write("\nData 2: ");
            while (!DateTime.TryParse(Console.ReadLine(), out data2))
            {
                Console.WriteLine("Formato de data invalido. Por favor, digite uma data valida no formato DD/MM/AAAA:");
            }

            int diferencaDias = calendario.CalcularDiferencaDias(data1, data2);
            Console.WriteLine($"\nDiferenca de dias entre {data1.ToShortDateString()} e {data2.ToShortDateString()}: {diferencaDias}");
        }
    }
}