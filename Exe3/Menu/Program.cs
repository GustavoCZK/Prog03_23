
int option = 0;

do
{
    Console.WriteLine("*************************************");
    Console.WriteLine("Menu de Opções Da Clínica veterinária");
    Console.WriteLine("*************************************");
    Console.WriteLine("");
    Console.WriteLine("1 - Cadastros");
    Console.WriteLine("2 - Relatórios");
    Console.WriteLine("0 - SAIR");
    
    option = Convert.ToInt32(Console.ReadLine());

    switch(option)
    {
        case 1 :
            MenuReg();
        break;

        case 2 :
            MenuRep();
        break;

        default :
        break;
    }
    
    static void MenuReg()
    {
        Console.WriteLine("***********************");
        Console.WriteLine("Você está em Cadastros.");
        Console.WriteLine("***********************");
        Console.WriteLine("");
        Console.WriteLine("1 - Médicos");
        Console.WriteLine("2 - Animais");
        Console.WriteLine("3 - Atendimentos");
        Console.WriteLine("0 - SAIR");
        Console.WriteLine("");

        int option = 0;

        option = Convert.ToInt32(Console.ReadLine());
            
        switch(option)
        {
            case 1 :
                Console.WriteLine("Cadastro para Médicos.../n");
            break;
                
            case 2 :
                Console.WriteLine("Cadastro para Animais.../n");
            break;

            case 3 :
                Console.WriteLine("Cadastro para Atendimentos.../n");
            break;

            default:
            break;
        }
            
    }

    static void MenuRep()
    {
        Console.WriteLine("************************");
        Console.WriteLine("Você está em Relatórios.");
        Console.WriteLine("************************");
        Console.WriteLine("");
        Console.WriteLine("1 - Atendimentos");
        Console.WriteLine("2 - Animais");
        Console.WriteLine("0 - SAIR");
        Console.WriteLine("");

        int option = 0;

        option = Convert.ToInt32(Console.ReadLine());
            
        switch(option)
        {
            case 1 :
                Console.WriteLine("Relatorios Sobre Atendimentos.../n");
            break;
               
            case 2 :
                Console.WriteLine("Relatótios Sobre Animais.../n");
            break;

            default:
            break;
        }
            
    }


}
while(option > 0);