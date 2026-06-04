using System;

public class Program
{
    static string CalcularMes(int m)
    {
         if (m == 1)
            return "Janeiro";
        else if (m == 2)
            return "Fevereiro";
        else if (m == 3)
            return "Março";
        else if (m == 4)
            return "Abriu";
        else if (m == 5)
            return "Maio";
        else if (m == 6)
            return "Junho";
        else if (m == 7)
            return "Julho";
        else if (m == 8)
            return "Agosto";
        else if (m == 9)
            return "Setembro";
        else if (m == 10)
            return "Outubro";
        else if (m == 11)
            return "Novembro";
        else if (m == 12)
            return "Dezembro";
        else
            return null;
    }
    public static void Main(string[] args)
    {
        int mes = Convert.ToInt32(Console.ReadLine());

        string dMes = CalcularMes(mes);

        if (dMes == null) Console.WriteLine("Mês inválido.");

        else Console.WriteLine($"Olá {dMes}.");
    }
}
