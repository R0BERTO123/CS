public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite a senha");
        string senha = Console.ReadLine();

        bool temNumero = false;
        bool temEspecial = false;
        string especial = "!@#$%^&*()_";

        foreach (char c in senha)
        {

            if (char.IsDigit(c))
            {
                temNumero = true;
            }

            if (especial.Contains(c))
            {
                temEspecial = true;
            }
        }

        bool senhaForte = senha.Length >= 6  && temNumero && temEspecial;     

        Console.WriteLine($"A senha cumpre os requisitos? {senhaForte}");
    }
}
