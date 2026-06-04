using System;

public class Program
{
    static string CalcularOcamento(double ganhos, double gastos)
    {
        if (ganhos > gastos)
        {
            return "OK";
        }
        else if (ganhos < gastos)
        {
            return "NOK";
        }
        else return "Erro";
        
    }
    public static void Main(string[] args)
    {
        double ganhos = Convert.ToInt32(Console.ReadLine());

        double gastos = Convert.ToInt32(Console.ReadLine());

        string ocamento = CalcularOcamento(ganhos, gastos);

        if (ocamento == "OK") Console.WriteLine("Você está dentro do orçamento!");
        else if (ocamento == "NOK") Console.WriteLine("Você está fora do orçamento! Não gaste mais!");  

    }
}
