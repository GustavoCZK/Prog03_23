// Operadores Usuários

using FluxoTiposExceptions.Classes;

int x = 5;
int incrementoPosFixado = x++; // 6
incrementoPosFixado++;
x++; x = x + 1;
int incrementoPreFixado = ++x;
Console.WriteLine($"PosFixado: {incrementoPosFixado}");
Console.WriteLine($"Prefixado: {incrementoPreFixado}");

// Como obter o tipo de uma variável
Type tipoDeInteiro = typeof(int);
Type tipoDex = x.GetType();

// Como obter o nome de uma variável
string nomeDaVariavel = nameof(x);
int quantosBytes = sizeof(int);

Console.WriteLine(
    "Nome Da Var: " + nomeDaVariavel + "\n" +
    "Ela tem " + quantosBytes + " Bytes.");

// Operadores de Atribuição
int p = 6;
Console.WriteLine($"{p}");
p += 3; // equivalente a p = p + 3
Console.WriteLine($"+={p}");
p -= 3; // equivalente a p = p - 3
Console.WriteLine($"-={p}");
p *= 3; // equivalente a p = p x 3
Console.WriteLine($"*={p}");
p /= 3; // equivalente a p = p / 3
Console.WriteLine($"/={p}");

// Operadores Lógicos

bool a = true;
bool b = false;

WriteLine($"AND  | a     | b    ");
WriteLine($"a    | {a & a, -5} | {a & b, -5}");
WriteLine($"b    | {b & a, -5} | {b & b, -5}");
WriteLine();
WriteLine($"OR   | a     | b    ");
WriteLine($"a    | {a | a, -5} | {a | b, -5} ");
WriteLine($"b    | {b | a, -5} | {b | b, -5} ");
WriteLine();
WriteLine($"XOR  | a     | b    ");
WriteLine($"a    | {a ^ a, -5} | {a ^ b, -5}");
WriteLine($"b    | {b ^ a, -5} | {b ^ b, -5}");

static bool FacaAlgo()
{
    WriteLine("Fazendo alguma coisa...");
    return true;
}
WriteLine();
WriteLine($"a & FacaAlgo() = {a & FacaAlgo()}");
WriteLine($"b & FacaAlgo() = {b & FacaAlgo()}");

// --------------------------------------------------
Animal[] animals = new Animal[] 
{
    new Cat{ 
        Name = "Garfield", 
        Born = new(year:2022,month:8, day:23),
        Legs = 4,
        IsDomestic = true 
        },
    null,
    new Cat{ 
        Name = "Mimi", 
        Born = new DateTime(year:1994,month:6, day:12),
        Legs = 4,
        IsDomestic = true 
        },
    new Spider{ 
        Name = "Piter Parker", 
        Born = DateTime.Today,
        Legs = 8,
        IsPoisonous = true 
        },
        new Spider{ 
        Name = "Eddie Brock", 
        Born = DateTime.Today,
        Legs = 8,
        IsPoisonous = true 
        },
};
// Laços de repetição
// 3 tipos de variaveis para controle de repetição
// 1: Flag - Bandeirinha, booleano que indica se para ou continua.
// 2: Counter - Contador, conta quantas vezes a repetiu. 
// 3: Acumulador - Permite acumular valores a cada repetição

// Laço For

for(int i = 0; i < animals.Length; i++)
{
    string message = string.Empty;
    if(animals[i] != null )
    {
        message = $"nome: {animals[i].Name} \n";
        message += $"Data de Nasc: {animals[i].Born.ToShortDateString()} \n";
    }
    Console.WriteLine(message);
} 

// Laço de repetição para cada / Foreach.
WriteLine("\n------FOREACH---------\n");
foreach( Animal animal in animals )
{
    string message = string.Empty;
    if(animal != null)
    {
        message += $"nome: {animal.Name} \n";
    }
    Console.WriteLine(message);
}