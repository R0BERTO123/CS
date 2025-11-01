public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o nome do autor");
        string autor = Console.ReadLine();

        Console.WriteLine("Digite o nome da obra");
        string obra = Console.ReadLine();

        Console.WriteLine("Qual é a cidade?");
       string cidade = Console.ReadLine();

        Console.WriteLine("Qual é a editora?");
        string editora = Console.ReadLine();

        Console.WriteLine("Qual é o ano?");
        int ano = int.Parse(Console.ReadLine());

        autor = autor.ToUpper();

        string ultimoNome = autor.Split(" ") [2];
        char primeraLetra = autor[0];

        Console.WriteLine($"{ultimoNome},{primeraLetra}. {obra}. {cidade}: {editora}, {ano}.");



    }
}