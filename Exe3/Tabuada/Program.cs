Console.WriteLine("------Tabuada------\n");

Console.WriteLine("Digite o numero da tabuada: ");
int baseN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Vezes(baseN);

static void Vezes(int baseN)
{   
    int multiplier = 1;
    while(multiplier <= 11)
    {
        Console.WriteLine($"{baseN} x {multiplier} = {baseN * multiplier}");
        multiplier += 1;
    }   
}

