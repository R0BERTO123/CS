using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite a data é hora");
        string dataHora = Console.ReadLine();

        if (DateTime.TryParse(dataHora, out DateTime dataHoraConverte))
        {

            string formataDataHora = dataHoraConverte.ToString("dd/MM/yyyy");
            Console.WriteLine(formataDataHora);
        }

        else
        {
             Console.WriteLine("erro");
        }
    
       

    }
}
