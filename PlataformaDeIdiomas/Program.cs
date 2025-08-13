using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite a data é hora");
        string dataHora = Console.ReadLine();

        Console.WriteLine("Digite o fuso");
        int fuso = int.Parse(Console.ReadLine());

        if (DateTime.TryParse(dataHora, out DateTime dataHoraConvertida))
        {
            DateTime dataHoraComFuso = dataHoraConvertida.AddHours(fuso);

            string dateHoraFormatada = dataHoraComFuso.ToString("yyyy-MM-dd HH:mm:ss");

            Console.WriteLine("Horário local: " + dateHoraFormatada);
            
        }
    }
}
