using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Controllers;
using Arquivos.Models;


namespace Arquivos.Searchs
{
    public class AnimalSearch
    {
        int option = 0;
        private AnimalController animalController;
        
        public AnimalSearch()
        {
            animalController = new AnimalController();
            this.SForAnimal();
        }

        public void SForAnimal()
        {
            Console.WriteLine("Escolha uma opção de pesquisa...");
            Console.WriteLine("1 - Id");
            Console.WriteLine("2 - Nome");
            Console.WriteLine("3 - Tipo");
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
                    SearchByType();
                break;

                default :
                break;

            }

        }
        private void SearchById()
        {
            Console.WriteLine("Pesquisar animal pelo ID!");
            Console.WriteLine("Digite o id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            foreach(Animal a in animalController.SearchById(id))
            {
                Console.WriteLine(a.ToString());
                Console.WriteLine("");
            }
        }
        private void SearchByName()
        {
            Console.WriteLine("Pesquisar animal pelo nome!");
            Console.WriteLine("Digite o nome:");
            string name = Console.ReadLine();
            Console.WriteLine("");

            foreach(Animal a in animalController.SearchByName(name))
            {
                Console.WriteLine(a.ToString());
                Console.WriteLine("");
            }

        }
        private void SearchByType()
        {
            Console.WriteLine("Pesquisar animal pelo tipo!");
            Console.WriteLine("Digite o tipo:");
            string tipo = Console.ReadLine();
            Console.WriteLine("");

            foreach(Animal a in animalController.SearchByType(tipo))
            {
                Console.WriteLine(a.ToString());
                Console.WriteLine("");
            }

        }
    }
}