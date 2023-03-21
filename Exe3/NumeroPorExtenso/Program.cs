﻿using NumeroPorExtenso;

Console.WriteLine("*******************************");
Console.WriteLine("Escrever Um Número Por Extenso");
Console.WriteLine("*******************************");

Console.WriteLine("Informe Um Número Inteiro: ");
string numero = Console.ReadLine();

int nro;
try
{
    nro = Convert.ToInt32(numero);
} 
catch
{
    Console.WriteLine("O número não é válido!");
    return;
}

string retorno = "";
switch (numero.Length)
{
    case 1 : 
        Unidade unidade = new Unidade();
        retorno = unidade.UnidadePorExtenso(nro);
    break;

    case 2 :
        Dezena dezena = new Dezena();
        retorno = dezena.DezenaPorExtenso(nro);
    break;
}
Console.WriteLine(retorno);