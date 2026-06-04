using System;
using System.Globalization;

public class Program
{
    static double ValorGSorvete(double gS)
    {
        if (gS <= 0) return -1;

        double precoG = 3.50;

        if (gS >= 1000)  precoG -= 0.50;

        double valor = precoG * (gS/100);

        return valor;
    }

    public static void Main(string[] args)
    {
            double gramas = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double valor = ValorGSorvete(gramas);

            if (valor == -1) Console.WriteLine("Peso inválido");

            else Console.WriteLine($"O total a pagar é R$ {valor.ToString("F2", CultureInfo.InvariantCulture)}");

    }
}