public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Qual é o valor total da compra?");
        double valorCompra = double.Parse(Console.ReadLine());

        Console.WriteLine("Qual é a quantidade de parcelas?");
        int parcelas = int.Parse(Console.ReadLine());

        Console.WriteLine("Qual é a taxa de juros mensal em porcentagem?");
        int taxa = int.Parse(Console.ReadLine());

        double taxaJuros = taxa / 100.0;

        double capital = valorCompra * Math.Pow(1 + taxaJuros, parcelas);
        double final = capital / parcelas;

        Console.WriteLine($"Sua compra ficará R$ {capital:F2} em {parcelas}x de R$ {final:F2} por mês.");
    }
}