using System;

public class Program
{
    static string Semaforo(string cor)
    {
        if (cor == "VERMELHO") return "Espere";

        else if (cor == "VERDE") return "Atravesse";

        else if (cor == "ROXO") return "Farol inoperante";

        else return "Cor Não 🤓";

        
    }
    public static void Main(string[] args)
    {
        string cor = Semaforo(Console.ReadLine().ToUpper());

        Console.WriteLine(cor);
    }
}
