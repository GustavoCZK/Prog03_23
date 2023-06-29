using Arquivos.Utils;
using Arquivos.Views;

/*
e exportação do arquivo.txt
*/

Bootstrapper.Charger();


int option = 0;

do
{
    Console.WriteLine("---------------------------------");
    Console.WriteLine("*******Clínica Veterinária*******");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("---------ABERTO 24 HORAS!--------");
    Console.WriteLine($"-------{DateTime.Now}-------");   
    Console.WriteLine("");
    Console.WriteLine("1 - Clientes");
    Console.WriteLine("2 - Animais");
    Console.WriteLine("3 - Médicos");
    Console.WriteLine("4 - Clínicas");
    Console.WriteLine("0 - Exit");
    Console.WriteLine("");
    
    option = Convert.ToInt32(Console.ReadLine());

    switch(option)
    {
        case 1 :
            Console.WriteLine("Opção Clientes");
            ClientView clientView = new ClientView();
        break;
        case 2 :
            Console.WriteLine("Opção Animals");
            AnimalView animalView = new AnimalView();
        break;
        case 3 :
            Console.WriteLine("Opão Médicos");
            DoctorView doctorView = new DoctorView();
        break;
        case 4 :
            Console.WriteLine("Opção Clínicas");
            ClinicView clinicView = new ClinicView();
        break;
    }




}
while(option > 0);