﻿using Arquivos.Utils;
using Arquivos.Views;

/*
e exportação do arquivo.txt
*/

Bootstrapper.ChargeClients();

int option = 0;

do
{
    Console.WriteLine("*******************************************");
    Console.WriteLine("Programa para leitura e exportação de dados");
    Console.WriteLine("*******************************************");
    Console.WriteLine("");
    Console.WriteLine("1 - Clientes");
    Console.WriteLine("2 - Animais");
    
    option = Convert.ToInt32(Console.ReadLine());

    switch(option)
    {
        case 1 :
            Console.WriteLine("Opção Clientes");
            ClientView clientView = new ClientView();
        break;
        case 2:
            Console.WriteLine("Opção Animals");
            AnimalView animalView = new AnimalView();
        break;
    }




}
while(option > 0);