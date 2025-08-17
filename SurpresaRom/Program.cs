using System;
using System.Globalization;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite a date é hora");
        string dataHora = Console.ReadLine();

        if (DateTimeOffset.TryParse(dataHora, out DateTimeOffset dataHoraDT))
        {
            
            TimeZoneInfo tzBrasil;
            if (OperatingSystem.IsWindows())
            {
                tzBrasil = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
            }
            else
            {
             tzBrasil = TimeZoneInfo.FindSystemTimeZoneById("America/Sao_Paulo");
            }


            DateTimeOffset fusoBrasil = TimeZoneInfo.ConvertTime(dataHoraDT, tzBrasil);

            string formata = fusoBrasil.ToString("yyyy-MM-dd HH:mm:ss");

            Console.WriteLine($"Avise o hotel em {formata} de Brasil/SãoPaulo");
        }
    }
}
