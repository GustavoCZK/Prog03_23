string password = "Samurai";
string retorno = String.Empty;

if(password.Length < 10)
{
    retorno = @"Sua senha é muito pequena. Deve haver ao menos 10 caracteries. ";
    retorno += "Seu JAGUARA!";
}
else if(password.Length > 15)
{
    retorno = @"Sua senha é muito grande. Deve haver entre 10 e 15 caracteries.";
}
else
{
    retorno = @"Sua senha está de acordo";
}

Console.WriteLine(retorno);

//Checagem de valor e tipo.

/*
    EM java script podemos fazer assim: 
    var a = "1";
    let b = 1;
    (a == b) retornará true...
    (a === b) retornará false...
*/

object o = "3";
int j = 4;
if(o is int i)
{
    Console.WriteLine($"{i} x {j} = {i * j}");
}
else
{
    Console.WriteLine(@"o não é um inteiro. Portanto não é possivel multiplicar.");
}

//comando switch
int number = Random.Shared.Next(1,6);
Console.WriteLine($"Meu numero aleátorio é {number}.");

switch(number)
{
    case 1: 
        Console.WriteLine("Um");
        break;
    case 2: 
        Console.WriteLine("Dois");
        break;
    case 3:
    case 4:
        Console.WriteLine("Três ou Quatro");
        goto case 1;
    case 5:
        goto A_label;
    default:
        Console.WriteLine("Default");
        break;
}

Console.WriteLine("Depois do Fim Do Switch");

A_label:
Console.WriteLine("Depois de A_label");