public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Qual é o nome do nome do filme?");
        string nomeFilme = Console.ReadLine();

        Console.WriteLine("Qual é a classificação?");
        int classificacaoFilme = int.Parse(Console.ReadLine());

        Console.WriteLine("Qual é a idade da primera pessoa?");
        int idadeP1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Qual é a idade da segunda pessoa?");
        int idadeP2 = int.Parse(Console.ReadLine());

        bool classificacaoLivre = true;

        if (classificacaoFilme != 0)
        {
            classificacaoLivre = false;
            if (idadeP1 >= classificacaoFilme && idadeP2 >= classificacaoFilme)
            {
                classificacaoLivre = true;
            }
        }

        Console.WriteLine($"Vamos assistir um filme? {classificacaoLivre}");
    }
}
