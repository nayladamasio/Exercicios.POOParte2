namespace Exerc03Parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();

         
            agenda.AdicionarContato("João", "985647553");
            agenda.AdicionarContato("Maria", "947569887");

            
            Console.WriteLine("Buscando contato por nome:");
            agenda.BuscarContatoPorNome("João");

            
            agenda.EditarContato("Maria", "000000000");

            Console.WriteLine("\nBuscando contato por número de telefone:");
            agenda.BuscarContatoPorNumeroTelefone("000000000");

            
            agenda.RemoverContato("João");

            Console.ReadLine();
        }
    }
}
