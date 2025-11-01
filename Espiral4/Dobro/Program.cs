using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero");
        int n = int.Parse(Console.ReadLine());

        int dobro = Dobrar(n);

        Console.WriteLine("O dobro de " + n + " é " + dobro);

    }

    public static int Dobrar(int numero)
    {
        int dobrar = numero * 2;
        return  dobrar;
    }
}