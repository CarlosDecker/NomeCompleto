    System.Console.Write("Digite seu nome e sobrenome: ");

string Nome = Console.ReadLine()!;

string PrimeiroNome = Nome.Substring(0, Nome.IndexOf(" "));
string Sobrenome = Nome.Substring(Nome.IndexOf(" ") + 1);

System.Console.WriteLine();
    System.Console.WriteLine("Nome completo: " + PrimeiroNome + " " + Sobrenome);
System.Console.WriteLine();
    System.Console.WriteLine("Nome de catálogo: " + Sobrenome + ", " + PrimeiroNome);
System.Console.WriteLine();
    System.Console.WriteLine("Pressione uma tecla para fechar...");
Console.ReadKey();