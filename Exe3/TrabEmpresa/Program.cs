using TrabEmpresa.Classes;

Console.WriteLine("Bem-Vindo a Empresa XY!");
Console.WriteLine("\n");

Console.WriteLine("O que podemos fazer por você?");
Console.WriteLine("\n");


Console.WriteLine("-----Códigos-----");
Console.WriteLine("1 - Parar");
Console.WriteLine("2 - Listar");
Console.WriteLine("-----------------");

string opcao = Console.ReadLine();
Console.WriteLine("\n");

Funcionario[] funcionarios = new Funcionario[] 
{
   new Gerente{ 
        Name = "Rodrigo", 
        Cargo = "Gerente",
        Genero = "Homem",
        Contratado = new(year:2009,month:2, day:14),
        Idade = "34 Anos",
        Isboss = true
        }, 
    new Supervisor{ 
        Name = "Angela", 
        Cargo = "Supervisora",
        Genero = "Mulher",
        Contratado = new(year:2014,month:7, day:25),
        Idade = "27 Anos",
        IsIntermediate = true
        },
    new Operario{ 
        Name = "Pedro",
        Cargo = "Operário",
        Genero = "Homem",
        Contratado = new DateTime(year:2016,month:7, day:23),
        Idade = "23 Anos",
        Isworker = true
        },
    new Operario{ 
        Name = "Fernanda",
        Cargo = "Operária", 
        Genero = "Mulher",
        Contratado = new DateTime(year:2017,month:2, day:18),
        Idade = "21 Anos",
        Isworker = true
        },
};

if(opcao == "1")
{
    Console.WriteLine("Obrigado pela Visita...");
    return;
}



if(opcao == "2")
{
    Console.WriteLine("---------------");
    Console.WriteLine("Pesquisando...");
    Console.WriteLine("---------------\n");
    foreach( Funcionario funcionario in funcionarios )
    {
        if(funcionario != null)
        {
            Console.WriteLine($"nome: {funcionario.Name}");
            Console.WriteLine($"Cargo: {funcionario.Cargo}");
            Console.WriteLine($"Contratação: {funcionario.Contratado} \n");
        }
    }
    Console.WriteLine("-------------------------");
    Console.WriteLine("Obrigado pela pesquisa...");
    Console.WriteLine("-------------------------");
}