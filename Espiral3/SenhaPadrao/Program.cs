using System;
using System.Text.RegularExpressions;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Qual é o nome?");
        string nome = Console.ReadLine();

        Console.WriteLine("Qual é o CPF?");
        string cpf = Console.ReadLine();
        cpf = Regex.Replace(cpf, "[^0-9]", "");

        Console.WriteLine("Qual é o numero de telefone?");
        string numero = Console.ReadLine();
        numero = Regex.Replace(numero, "[^0-9]", "");

        string primeroNome = nome.Split(" ")[0];
        char primeiraLetraNome = primeroNome[0];

        string sobrenome = nome.Split(" ")[2];
        char primeiraLetraSobrenome = sobrenome[0];


        string cpftres = cpf.Substring(0, 3);

        string numeroDois = numero.Substring(5, 2);


        Console.WriteLine($"Senha criada: {primeiraLetraNome}{primeiraLetraSobrenome}{cpftres}{numeroDois}");
       
       
        
    }
}
