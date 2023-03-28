// Operadores Usuários

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
p += 3; // equivalente a p = p + 3
p -= 3; // equivalente a p = p - 3
p *= 3; // equivalente a p = p x 3
p /= 3; // equivalente a p = p / 3

Console.WriteLine($"+={p}");