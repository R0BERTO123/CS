public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Qual é previsão da temperatura do dia?");
        double temperatura = double.Parse(Console.ReadLine());

        bool apropriado = temperatura >= 23 || temperatura <= 30;

        Console.WriteLine($"Vamos ao parque? {apropriado}");

    }
}
