using Arquivos.Models;
using Arquivos.Controllers;

namespace Arquivos.Views
{
    public class AnimalView
    {
        private AnimalController animalController;

        public AnimalView()
        {
            animalController = new AnimalController();
            this.Init();
        }
        public void Init()
        {
            Console.WriteLine("**********************");
            Console.WriteLine("Você está em Animais.");
            Console.WriteLine("**********************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir Animais");
            Console.WriteLine("2 - Listar Animais");
            Console.WriteLine("3 - Exportar Animais");
            Console.WriteLine("4 - Importar Animais");
            Console.WriteLine("");

            int option = 0;

            option = Convert.ToInt32(Console.ReadLine());
            
            switch(option)
            {
                case 1 :
                    Insert();
                break;
                case 2 :
                    List();
                break;
                case 3 :
                    Export();
                break;
                case 4 :
                    Import();
                break;

                default:
                break;
            }
            
        }

        private void List()
        {
            List<Animal> listagem = animalController.List();
            //Controlador + Acumulador + Flag
            for(int i = 0; i < listagem.Count; i++)
            {
                Console.WriteLine(Print(listagem[i]));
            }
        }

        private string Print(Animal animal)
        {
            string retorno = "";
            retorno += $"Id: {animal.Id} \n";
            retorno += $"Nome: {animal.Name} \n";
            retorno += "------------------------------------------- \n";

            return retorno;
        }


        private void Insert()
        {
            Animal animal = new Animal();
            animal.Id = animalController.GetNextId();

            Console.WriteLine("\nInforme O Nome do Animal: ");
            animal.Name = Console.ReadLine();

            Console.WriteLine("\nInforme O Tipo de Animal: ");
            animal.Tipo = Console.ReadLine();
            
            Console.WriteLine("\nInforme O Sexo do Animal: \n");
            animal.Sexo = Console.ReadLine();

            bool retorno = animalController.Insert(animal);

            if(retorno == true)
            {
                Console.WriteLine("Animal inserido com sucesso!");
            }
            else
                Console.WriteLine("Falha ao inserir, verifique os dados!");
        }
        private void Export()
        {
            if(animalController.ExportToTextFile())
            {
                Console.WriteLine("Arquivo gerado com sucesso!");
            }
            else
                Console.WriteLine("Oooops... Notthing");
        }
        private void Import()
        {
            if(animalController.ImportFromTxtFile())
            {
                Console.WriteLine("Dados importados com sucesso!");
            }
            else
                Console.WriteLine("Oooops... Notthing");
        }
    }
}