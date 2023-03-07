Console.WriteLine("Olá, Seja Bem-Vindo!");
Console.WriteLine("Olá, Qual é seu nome?");
string name = Console.ReadLine();
Console.WriteLine($"Olá {name} Praser em conhece-lo!");

// Declarar sem innicializar / Primitivo

string message1; 
// Declarar inicializado / Abstrato
String message2 = "Seu Nome Completo";

// Declarar string vazia
string message3 = String.Empty;
string message4 = "";

// Declaração com tipo implícito
var message5 = "Mensagem Aleatória";

message1 = "Nomenclatura;Pelé;The Rock;Roberto Carlos";
var palavras = message1.Split(';');
foreach(var word in palavras)
{
    // variavel de escopo local do laço de repetição foreach
    int a = 10;
    Console.WriteLine(word);
}