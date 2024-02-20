namespace Exerc04Parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaquinaDeVendas maquina = new MaquinaDeVendas();

            maquina.CadastrarProduto("Macarrao", 3.0m, 10);
            maquina.CadastrarProduto("Salgadinho", 1.5m, 15);
            maquina.CadastrarProduto("Chocolate", 3m, 8);

            maquina.ExibirEstoque();

            maquina.InserirDinheiro(5);
            maquina.SelecionarProduto("Chocolate");

            decimal troco = maquina.RetornarTroco();

        }
    }
}
