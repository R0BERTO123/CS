using System;

public class Program
{
    static double ValorIngresso(string t, int q)
    {
        double valor = 0;
        if (t == "MEIA")
        {
            valor = (28.50 * q) / 2;
            
        }
        else if (t == "INTEIRA")
        {
             valor = 28.50 * q;
            
        }
        return valor;
    }
    public static void Main(string[] args)
    {
        string tipo = Console.ReadLine().ToUpper();
        int quantidade = Convert.ToInt32(Console.ReadLine());

        double valor = ValorIngresso(tipo, quantidade);

        Console.WriteLine($"O total a pagar é R$ {valor:F2}");
    }
}