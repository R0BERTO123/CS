using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite a data é hora");
        string dataHora = Console.ReadLine();

        Console.WriteLine("Qual é o tempo da viagem?");
        int tempo = int.Parse(Console.ReadLine());

        Console.WriteLine("Qual é o fuso?");
        int fuso = int.Parse(Console.ReadLine());

       

        if (DateTimeOffset.TryParse(dataHora, out DateTimeOffset  dataHoraDT))
        {
            DateTimeOffset tempoViagem = dataHoraDT.AddHours(tempo);

            DateTimeOffset chegadaDestino = tempoViagem.ToOffset(TimeSpan.FromHours(fuso));

            string formata = chegadaDestino.ToString("yyyy-MM-dd HH:mm:ss");

            Console.WriteLine($"Você chegará em {formata}");
        }

    }
}