public class UltimoNome
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite seu nome completo");
        string nome = Console.ReadLine();

        string ultimoNome = nome.Split(" ")[1];

        Console.WriteLine("Seja bem-vindo " + ultimoNome);
    }
}
