namespace Exerc01Parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa("Pedro", 24, "Professor");
            pessoa1.ExibirInformacoes();
            Console.WriteLine("Idade em anos bissextos: " + pessoa1.CalcularIdadeEmBissextos());

            Pessoa pessoa2 = new Pessoa("Ana", 32, "Dentista");
            pessoa2.ExibirInformacoes();
            Console.WriteLine("Idade em anos bissextos: " + pessoa2.CalcularIdadeEmBissextos());
        }
    }
}
