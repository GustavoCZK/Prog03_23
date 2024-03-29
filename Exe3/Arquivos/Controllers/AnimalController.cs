using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Controllers

{
    public class AnimalController
    {
        private string directoryName = "ReportFiles";
        private string fileName = "Animais.txt";
        public List<Animal> List()
        {
            return DataSet.Animals;
        }

        public bool Insert(Animal animal)
        {
            if(animal == null)
                return false;
            
            if(animal.Id <= 0)
                return false;
            
            if(string.IsNullOrWhiteSpace(animal.Name))
                return false;
            
            DataSet.Animals.Add(animal);
            return true;

        }
        public bool ExportToTextFile()
        {

            if(!Directory.Exists(directoryName))
                Directory.CreateDirectory(directoryName);

            string fileContent = string.Empty;
            foreach(Animal a in DataSet.Animals)
            {
                fileContent += $"{a.Id} ; {a.Name} ; {a.Tipo} ; {a.Sexo} ";
                fileContent += "\n";
            }   

            try
            {
            StreamWriter sw = File.CreateText($"{directoryName}\\{fileName}");
            sw.Write(fileContent);
            sw.Close();
            }
            catch(IOException ioEx)
            {
                Console.WriteLine("Erro ao manipular o arquivo.");
                Console.WriteLine(ioEx.Message);
                return false;
            }
            return true;
        }

        public  bool  ImportFromTxtFile()
        {
            try
            {
                StreamReader sr = new StreamReader($"{directoryName}\\{fileName}");

            string line = string.Empty;
            line = sr.ReadLine();
            while(line != null)
            {
                Animal animal = new Animal();
                string[] clientData = line.Split(';');
                animal.Id = Convert.ToInt32(clientData[0]);
                animal.Name = clientData[1];
                animal.Tipo = clientData[2];
                animal.Sexo = clientData[3];

                DataSet.Animals.Add(animal);
                
                line = sr.ReadLine();
            }
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Oooopss... Notthing found!! Ocorreu um erro ao importar os dados.");
                Console.WriteLine(ex.Message);
                return false;
            }
            


        }


        public int GetNextId()
        {
            int tam = DataSet.Animals.Count;

            if(tam > 0)
            {
                return DataSet.Animals[tam - 1].Id + 1;
            }
            else
                return 1;
        }        
    }
}
