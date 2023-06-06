using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Data;
using Arquivos.Models;
using Arquivos.Controllers;
namespace Arquivos.Views
{
    public class ClientView
    {
        private ClientController clientController;

        public ClientView()
        {
            clientController = new ClientController();
            this.Init();
        }
        public void Init()
        {
            Console.WriteLine("**********************");
            Console.WriteLine("Você está em clientes.");
            Console.WriteLine("**********************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir Clientes");
            Console.WriteLine("2 - Listar Clientes");
            Console.WriteLine("3 - Exportar Clientes");
            Console.WriteLine("4 - Importar Clientes");
            Console.WriteLine("");

            int option = 0;

            option = Convert.ToInt32(Console.ReadLine());
            
            switch(option)
            {
                case 1 :
                    Insert();
                break;
              
                default:
                break;
            }
            
        }

        private void Insert()
        {
            Client client = new Client();
            //client.Id = 

            Console.WriteLine("\nInforme O Seu Primeiro Nome: ");
            client.FirstName = Console.ReadLine();

            Console.WriteLine("\nInforme O Seu Sobrenome: ");
            client.LastName = Console.ReadLine();

            Console.WriteLine("\nInforme O Seu CPF: ");
            client.CPF = Console.ReadLine();
            
            Console.WriteLine("\nInforme O Seu Email: ");
            client.Email = Console.ReadLine();
        }

    }
}