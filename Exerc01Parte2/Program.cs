namespace Exerc01Parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("\nDigite a sua idade:");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite a sua profissao:");
            string profissao = Console.ReadLine();

            Pessoa pessoa = new Pessoa(nome, idade, profissao);
            pessoa.ExibirInformacoes();
            Console.WriteLine("\nIdade em anos bissextos: " + pessoa.CalcularIdadeEmBissextos());
        }
    }
}