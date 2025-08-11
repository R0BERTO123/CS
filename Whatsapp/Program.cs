using System;
using System.Text.RegularExpressions;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Qual é o numero?");
        string numero = Console.ReadLine();

        numero = Regex.Replace(numero, "[^0-9]", "");

        Console.WriteLine($"https://api.whatsapp.com/send?phone={numero}");
    }
}
