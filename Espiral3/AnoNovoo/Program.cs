using System;
using System.Globalization;
public class Program
{
    public static void Main(string[] args)
    {
     Console.WriteLine("Digite a data e hora");
        string dataHoraString = Console.ReadLine();

        Console.WriteLine("Digite o fuso");
        int fusoLocal = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a cidade de destino");
        string cidade = Console.ReadLine();

        Console.WriteLine("Digite o fuso da cidade de destino");
        int fusoDestino = int.Parse(Console.ReadLine());

        DateTime dataHora = DateTime.ParseExact(
            dataHoraString,
            "yyyy-MM-dd HH:mm:ss",
            CultureInfo.InvariantCulture
        );

        DateTime dataHoraDestino = dataHora.AddHours(fusoDestino - fusoLocal);

        bool jaEAnoNovo = dataHoraDestino.Month == 1 && dataHoraDestino.Day == 1;

        Console.WriteLine($"Já é Ano Novo em {cidade}? {jaEAnoNovo}");
    }
}

        
