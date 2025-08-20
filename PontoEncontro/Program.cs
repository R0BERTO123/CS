using System;
public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Qual é a data é hora do ponto de emcontro? ");
        string dataHoraPonto = Console.ReadLine();

        Console.WriteLine("Qual é o fuso horario da pessoa 1?");
        int fusoP1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Quais são as horas para a pessoa 1 chegar no ponto de encontro?");
        int horasP1 = int.Parse(Console.ReadLine());
        horasP1 = -Math.Abs(horasP1);

        Console.WriteLine("Qual é o fuso horario da pessoa 2?");
        int fusoP2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Quais são as horas para a pessoa 2 chegar no ponto de encontro?");
        int horasP2 = int.Parse(Console.ReadLine());
        horasP2 = -Math.Abs(horasP2);

        if (DateTimeOffset.TryParse(dataHoraPonto, out DateTimeOffset dataHoraPontoDT))
        {
            DateTimeOffset addFusoP1 = dataHoraPontoDT.ToOffset(TimeSpan.FromHours(fusoP1));
            DateTimeOffset addFusoP2 = dataHoraPontoDT.ToOffset(TimeSpan.FromHours(fusoP2));

            DateTimeOffset horaChegadaP1 = addFusoP1.AddHours(horasP1);
            DateTimeOffset horaChegadaP2 = addFusoP2.AddHours(horasP2);

            string formataP1 = horaChegadaP1.ToString("yyyy-MM-dd HH:mm:ss");
            string formataP2 = horaChegadaP2.ToString("yyyy-MM-dd HH:mm:ss");

            Console.WriteLine($"A primeira pessoa deve sair em {formataP1}");
            Console.WriteLine($"A segunda pessoa deve sair em {formataP2}");
        }
    }
}
