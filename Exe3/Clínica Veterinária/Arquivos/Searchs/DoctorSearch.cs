using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Controllers;
using Arquivos.Models;

namespace Arquivos.Searchs
{
    public class DoctorSearch
    {
        int option = 0;
        private DoctorController doctorController;
        
        public DoctorSearch()
        {
            doctorController = new DoctorController();
            this.SForDoctor();
        }

        public void SForDoctor()
        {
            Console.WriteLine("Escolha uma opção de pesquisa...");
            Console.WriteLine("1 - Id");
            Console.WriteLine("2 - Nome");
            Console.WriteLine("3 - CPF");
            Console.WriteLine("4 - Clínica");
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

                case 4 :
                    SearchByClinic();
                break;

                default :
                break;

            }
        }

        private void SearchByName()
        {
            Console.WriteLine("Pesquisar médico pelo nome!");
            Console.WriteLine("Digite o nome:");
            string name = Console.ReadLine();
            Console.WriteLine("");

            foreach(Doctor d in doctorController.SearchByname(name))
            {
                Console.WriteLine(d.ToString());
                Console.WriteLine("");
            }

        }
        private void SearchById()
        {
            Console.WriteLine("Pesquisar médico pelo ID!");
            Console.WriteLine("Digite o id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            foreach(Doctor d in doctorController.SearchById(id))
            {
                Console.WriteLine(d.ToString());
                Console.WriteLine("");
            }
            
        }

        private void SearchByCPF()
        {
            Console.WriteLine("Pesquisar médico pelo CPF!");
            Console.WriteLine("Não se esqueça dos pontos! \nEx: 000.000.000.00");
            Console.WriteLine("");
            Console.WriteLine("Digite o CPF:");
            
            string CPF = Console.ReadLine();
            Console.WriteLine("");

            foreach(Doctor d in doctorController.SearchByCPF(CPF))
            {
                Console.WriteLine(d.ToString());
                Console.WriteLine("");
            }
            
        }

        private void SearchByClinic()
        {
            Console.WriteLine("Pesquisar médico pelo nome!");
            Console.WriteLine("Digite o nome:");
            string clinic = Console.ReadLine();
            Console.WriteLine("");

            foreach(Doctor d in doctorController.SearchByClinic(clinic))
            {
                Console.WriteLine(d.ToString());
                Console.WriteLine("");
            }

        }
    }
}