public class Program
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Qual é o mês?");
        string mes = Console.ReadLine();

        Console.WriteLine("Qual é o dia?");
        int dia = int.Parse(Console.ReadLine());

        bool eDeLibra = false;

        mes = mes.ToUpper();

        if (mes.Equals("SETEMBRO") && dia >= 23)
        {
            eDeLibra = true;
        }

        else if (mes.Equals("OUTUBRO") && dia <= 22)
        {
            eDeLibra = true;
       }

        Console.WriteLine($"É do signo de Libra? {eDeLibra}");
    }
}
