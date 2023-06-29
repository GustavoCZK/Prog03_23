using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Controllers;
using Arquivos.Models;
using Arquivos.Data;

namespace Arquivos.Searchs
{
    public class ClientSearch
    {
        int option = 0;
        private ClientController clientController;
        
        public ClientSearch()
        {
            clientController = new ClientController();
            this.SForClient();
        }

        public void SForClient()
        {
            Console.WriteLine("Escolha uma opção de pesquisa...");
            Console.WriteLine("1 - Id");
            Console.WriteLine("2 - Nome");
            Console.WriteLine("3 - CPF");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("");

            option = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1 :
                    SearchById();
                break;
                
                case 2 :
                    SearchByName(); 
                break;
                
                case 3 :
                    SearchByCPF();
                break;

                default :
                break;

            }
        }

        private void SearchByName()
        {
            Console.WriteLine("Pesquisar cliente pelo nome!");
            Console.WriteLine("Digite o nome:");
            string name = Console.ReadLine();
            Console.WriteLine("");

            foreach(Client c in clientController.SearchByname(name))
            {
                Console.WriteLine(c.ToString());
                Console.WriteLine("");
            }

        }
        private void SearchById()
        {
            Console.WriteLine("Pesquisar cliente pelo ID!");
            Console.WriteLine("Digite o id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            foreach(Client c in clientController.SearchById(id))
            {
                Console.WriteLine(c.ToString());
                Console.WriteLine("");
            }
            
        }

        private void SearchByCPF()
        {
            Console.WriteLine("Pesquisar cliente pelo CPF!");
            Console.WriteLine("Não se esqueça dos pontos! \nEx: 000.000.000.00");
            Console.WriteLine("");
            Console.WriteLine("Digite o CPF:");
            
            string CPF = Console.ReadLine();
            Console.WriteLine("");

            foreach(Client c in clientController.SearchByCPF(CPF))
            {
                Console.WriteLine(c.ToString());
                Console.WriteLine("");
            }
            
        }


    }
}