
Console.WriteLine("Digite uma cor");
string cor = Console.ReadLine();
cor = cor.ToLower();

bool corPrimaria = cor == "azul" || cor == "vermelho" || cor == "amarelo";

Console.WriteLine($"É cor primária? {corPrimaria}");