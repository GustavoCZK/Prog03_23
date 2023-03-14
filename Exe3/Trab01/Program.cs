static void FormatString(string Number)
{
    Number.Replace("1","Um");
}

static string FormatReturningString(string Number)
{
    return Number.Replace("1", "Um");
}
Console.WriteLine("Digite um numero entre 0 até 1000: ");
string Number = Console.ReadLine();
Console.WriteLine(Number);

int QtdChar = Number.Length + 1;