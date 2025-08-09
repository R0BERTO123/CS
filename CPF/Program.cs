using System.Text.RegularExpressions;
using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite seu CPF");
        string cpf = Console.ReadLine();

        // cpf = cpf.Replace(" ", "").Replace(".", "").Replace("-","");
        cpf = Regex.Replace(cpf, "[^0-9]", "");

        cpf = cpf.Insert(3, ".").Insert(7,".").Insert(11,"-");


        Console.WriteLine(cpf);
    }
}
