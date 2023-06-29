using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Models;
using Arquivos.Controllers;

namespace Arquivos.Searchs
{
    public class ClinicSearch
    {
        int option = 0;
        private ClinicController clinicController;
        
        public ClinicSearch()
        {
            clinicController = new ClinicController();
            this.SForClinic();
        }

        public void SForClinic()
        {
            Console.WriteLine("Escolha uma opção de pesquisa...");
            Console.WriteLine("1 - Id");
            Console.WriteLine("2 - Nome");
            Console.WriteLine("3 - Telefone");
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
                    SearchByPhone();
                break;

                default :
                break;

            }
        }

        private void SearchByName()
        {
            Console.WriteLine("Pesquisar Clínica pelo nome!");
            Console.WriteLine("Digite o nome:");
            string name = Console.ReadLine();
            Console.WriteLine("");

            foreach(Clinic c in clinicController.SearchByname(name))
            {
                Console.WriteLine(c.ToString());
                Console.WriteLine("");
            }

        }
        private void SearchById()
        {
            Console.WriteLine("Pesquisar Clínica pelo ID!");
            Console.WriteLine("Digite o id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            foreach(Clinic c in clinicController.SearchById(id))
            {
                Console.WriteLine(c.ToString());
                Console.WriteLine("");
            }
            
        }

        private void SearchByPhone()
        {
            Console.WriteLine("Pesquisar Clínica pelo Telefone!");
            Console.WriteLine("Não se esqueça dos pontos! \nEx: (00)00000-0000");
            Console.WriteLine("");
            Console.WriteLine("Digite o CPF:");
            
            string Phone = Console.ReadLine();
            Console.WriteLine("");

            foreach(Clinic c in clinicController.SearchByPhone(Phone))
            {
                Console.WriteLine(c.ToString());
                Console.WriteLine("");
            }
            
        }
    }
}