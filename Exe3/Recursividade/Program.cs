Console.WriteLine("**************************");
Console.WriteLine("Cálculo Fatorial Recursivo");
Console.WriteLine("**************************");
Console.WriteLine();

Console.WriteLine("Digite um numero: ");
int numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Fatorial de {numero} é {Factorial(numero)}");


static int Factorial(int number)
{
    // Caso Base 1
    if(number < 0)
    {
        throw new ArgumentException(
            message: $"A função não suporta numeros negativos. Input{number}",
            paramName: nameof(number)
        );
    }
    else if(number == 0) // Caso base 2
    {
        return 1;
    }
    else // Caso recursivo 
    {
        return number * Factorial(number - 1);
    }
}