// See https://aka.ms/new-console-template for more information

Console.WriteLine("Qual é o valor da primeira posição?");
int a1 = int.Parse(Console.ReadLine());

Console.WriteLine("Qual é a razão?");
int razao = int.Parse(Console.ReadLine());

Console.WriteLine("Qual é a posição desejada?");
int posicao = int.Parse(Console.ReadLine());

double termo = a1 * Math.Pow(razao, posicao - 1);

Console.WriteLine($"O valor do termo na posição {posicao} é {termo}");


