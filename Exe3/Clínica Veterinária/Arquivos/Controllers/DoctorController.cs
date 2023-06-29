using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Controllers
{
    public class DoctorController
    {
        private string directoryName = "ReportFiles";
        private string fileName = "Doctors.txt";
        public List<Doctor> List()
        {
            return DataSet.Doctors;
        }

        public bool Insert(Doctor doctor)
        {
            if(doctor == null)
                return false;
            
            if(doctor.Id <= 0)
                return false;
            
            if(string.IsNullOrWhiteSpace(doctor.FirstName))
                return false;
            
            DataSet.Doctors.Add(doctor);
            return true;

        }

        public bool ExportToTextFile()
        {

            if(!Directory.Exists(directoryName))
                Directory.CreateDirectory(directoryName);

            string fileContent = string.Empty;
            foreach(Doctor d in DataSet.Doctors)
            {
                fileContent += $"{d.Id};{d.CPF};{d.FirstName};{d.LastName};{d.Email};{d.ClinicName}";
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
                    Doctor doctor = new Doctor();
                    string[] doctorData = line.Split(';');
                    doctor.Id = Convert.ToInt32(doctorData[0]);
                    doctor.CPF = doctorData[1];
                    doctor.FirstName = doctorData[2];
                    doctor.LastName = doctorData[3];
                    doctor.Email = doctorData[4];
                    doctor.ClinicName = doctorData[5];

                    DataSet.Doctors.Add(doctor);

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
        public List<Doctor> SearchById(int id)
        {
            if( id > DataSet.Doctors.Count || id < 0)
            {
                return null;
            }
            List<Doctor> doctors = new List<Doctor>();
            for(int i = 0; i < DataSet.Doctors.Count; i++)
            {
                var d = DataSet.Doctors[i];
                if(d.Id == id)
                {
                    doctors.Add(d);
                }
            }
            return doctors;
        }

        public List<Doctor> SearchByname(string name)
        {
            if(string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                return null;
            }
            List<Doctor> doctors  = new List<Doctor>();
            for(int i = 0; i < DataSet.Doctors.Count; i++)
            {
                var d = DataSet.Doctors[i];
                if(d.FullName.ToLower().Contains(name.ToLower()))
                {
                    doctors.Add(d);
                }
            }
            return doctors;
        }
        
        public List<Doctor> SearchByCPF(string CPF)
        {
            if(string.IsNullOrEmpty(CPF) || string.IsNullOrWhiteSpace(CPF))
            {
                return null;
            }
            List<Doctor> doctors = new List<Doctor>();
            for(int i = 0; i < DataSet.Doctors.Count; i++)
            {
                var d = DataSet.Doctors[i];
                if(d.CPF.Contains(CPF))
                {
                    doctors.Add(d);
                }
            }
            return doctors;
        }

        public int GetNextId()
        {
            int tam = DataSet.Doctors.Count;

            if(tam > 0)
            {
                return DataSet.Doctors[tam - 1].Id + 1;
            }
            else
                return 1;
        }

        public List<Doctor> SearchByClinic(string clinic)
        {
            if(string.IsNullOrEmpty(clinic) || string.IsNullOrWhiteSpace(clinic))
            {
                return null;
            }
            List<Doctor> doctors  = new List<Doctor>();
            for(int i = 0; i < DataSet.Doctors.Count; i++)
            {
                var d = DataSet.Doctors[i];
                if(d.ClinicName.ToLower().Contains(clinic.ToLower()))
                {
                    doctors.Add(d);
                }
            }
            return doctors;
        }
    }
}