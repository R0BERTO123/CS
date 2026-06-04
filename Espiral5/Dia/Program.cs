using System;

public class Program
{
    static string CalcularDia(int d)
    {
        if (d == 0) {
            return "Domingo";
        } else if (d == 1) {
            return "Segunda";
        } else if (d == 2) {
            return "Terça";
        } else if (d == 3) {
            return "Quarta";
        } else if (d == 4) {
            return "Quinta";
        } else if (d == 5) {
            return "Sexta";
        } else if (d == 6) {
            return "Sábado";
        }
        return null;
    }
    public static void Main(string[] args)
    {
        int dia = Convert.ToInt32(Console.ReadLine());

        string dSemana = CalcularDia(dia);

        if (dSemana == null) Console.WriteLine("Dia da semana inválido.");

        else Console.WriteLine($"O dia {dia} é {dSemana}.");
    }
}
