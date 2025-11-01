using System;

public class Program

{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite três numeros");
        int numero1 = int.Parse(Console.ReadLine());
        int numero2 = int.Parse(Console.ReadLine());
        int numero3 = int.Parse(Console.ReadLine());

        int chamaFunction1 = Dobrar1(numero1);
        int chamaFunction2 = Dobrar2(numero2);
        int chamaFunction3 = Dobrar3(numero3);

        Console.WriteLine("O dobro de " + numero1 + " é " + chamaFunction1);
        Console.WriteLine("O dobro de " + numero2 + " é " + chamaFunction2);
        Console.WriteLine("O dobro de " + numero3 + " é " + chamaFunction3);
    }


    public static int Dobrar1(int n1)
    {
        int dobro1 = n1 * 2;
        return dobro1;
    }

    public static int Dobrar2(int n2)
    {
        int dobro2 = n2 * 2;
        return dobro2;
    }
    
       public static int Dobrar3(int n3)
    {
        int dobro3 = n3 * 2;
        return dobro3;
    }

   
}