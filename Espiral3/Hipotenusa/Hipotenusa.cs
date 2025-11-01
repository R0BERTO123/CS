public class Hipotenusa
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Digite o valor do primero cateto");
        double cateto1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor do segundo cateto");
        double cateto2 = double.Parse(Console.ReadLine());

        double hipotenusa = Math.Sqrt(Math.Pow(cateto1,2)+Math.Pow(cateto2,2));

        Console.WriteLine($"A hipotenusa é {hipotenusa}");

    }
        
    
}