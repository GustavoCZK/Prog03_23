using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Controllers
{
    public class ClinicController
    {
        private string directoryName = "ReportFiles";
        private string fileName = "Clinics.txt";
        public List<Clinic> List()
        {
            return DataSet.Clinics;
        }

        public bool Insert(Clinic clinic)
        {
            if(clinic == null)
                return false;
            
            if(clinic.Id <= 0)
                return false;
            
            if(string.IsNullOrWhiteSpace(clinic.Name))
                return false;
            
            DataSet.Clinics.Add(clinic);
            return true;

        }

        public bool ExportToTextFile()
        {

            if(!Directory.Exists(directoryName))
                Directory.CreateDirectory(directoryName);

            string fileContent = string.Empty;
            foreach(Clinic c in DataSet.Clinics)
            {
                fileContent += $"{c.Id};{c.Name};{c.Telefone};{c.Endereco}";
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
                    Clinic clinic = new Clinic();
                    string[] clinicData = line.Split(';');
                    clinic.Id = Convert.ToInt32(clinicData[0]);
                    clinic.Name = clinicData[1];
                    clinic.Telefone = clinicData[2];
                    clinic.Endereco = clinicData[3];

                    DataSet.Clinics.Add(clinic);

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
        public List<Clinic> SearchById(int id)
        {
            if( id > DataSet.Clinics.Count || id < 0)
            {
                return null;
            }
            List<Clinic> clinics = new List<Clinic>();
            for(int i = 0; i < DataSet.Clinics.Count; i++)
            {
                var c = DataSet.Clinics[i];
                if(c.Id == id)
                {
                    clinics.Add(c);
                }
            }
            return clinics;
        }

        public List<Clinic> SearchByname(string name)
        {
            if(string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                return null;
            }
            List<Clinic> clinics  = new List<Clinic>();
            for(int i = 0; i < DataSet.Clinics.Count; i++)
            {
                var c = DataSet.Clinics[i];
                if(c.Name.ToLower().Contains(name.ToLower()))
                {
                    clinics.Add(c);
                }
            }
            return clinics;
        }
        
        public List<Clinic> SearchByPhone(string Telefone)
        {
            if(string.IsNullOrEmpty(Telefone) || string.IsNullOrWhiteSpace(Telefone))
            {
                return null;
            }
            List<Clinic> clinics = new List<Clinic>();
            for(int i = 0; i < DataSet.Clinics.Count; i++)
            {
                var d = DataSet.Clinics[i];
                if(d.Telefone.Contains(Telefone))
                {
                    clinics.Add(d);
                }
            }
            return clinics;
        }

        public int GetNextId()
        {
            int tam = DataSet.Clinics.Count;

            if(tam > 0)
            {
                return DataSet.Clinics[tam - 1].Id + 1;
            }
            else
                return 1;
        }

    }
}