using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Controllers;
using Arquivos.Models;
using Arquivos.Searchs;

namespace Arquivos.Views
{
    public class DoctorView
    {
        private DoctorController doctorController;

        public DoctorView()
        {
            doctorController = new DoctorController();
            this.Init();
        }
        public void Init()
        {
            Console.WriteLine("**********************");
            Console.WriteLine("Você está em Médicos.");
            Console.WriteLine("**********************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir Médicos");
            Console.WriteLine("2 - Listar Médicos");
            Console.WriteLine("3 - Exportar Médicos");
            Console.WriteLine("4 - Importar Médicos");
            Console.WriteLine("5 - Pesquisar Médicos");
            Console.WriteLine("0 - Exit");
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
                case 5 :
                    DoctorSearch doctorSearch = new DoctorSearch();
                break;

                default:
                break;
            }
            
        }

        private void List()
        {
            List<Doctor> listagem = doctorController.List();
            //Controlador + Acumulador + Flag
            for(int i = 0; i < listagem.Count; i++)
            {
                Console.WriteLine(Print(listagem[i]));
            }
        }

        private string Print(Doctor doctor)
        {
            string retorno = "";
            retorno += $"Id: {doctor.Id} \n";
            retorno += $"Nome: {doctor.FirstName} {doctor.LastName} \n";
            retorno += $"CPF: {doctor.CPF} \n";
            retorno += $"Clínica: {doctor.ClinicName} \n";
            retorno += "------------------------------------------- \n";

            return retorno;
        }


        private void Insert()
        {
            Doctor doctor = new Doctor();
            doctor.Id = doctorController.GetNextId();

            Console.WriteLine("\nInforme O Seu Primeiro Nome: ");
            doctor.FirstName = Console.ReadLine();

            Console.WriteLine("\nInforme O Seu Sobrenome: ");
            doctor.LastName = Console.ReadLine();

            Console.WriteLine("\nInforme O Seu CPF: ");
            doctor.CPF = Console.ReadLine();
            
            Console.WriteLine("\nInforme O Seu Email: ");
            doctor.Email = Console.ReadLine();

            Console.WriteLine("\nInforme O Sua Clínica: ");
            doctor.ClinicName = Console.ReadLine();

            bool retorno = doctorController.Insert(doctor);

            if(retorno == true)
            {
                Console.WriteLine("Médico inserido com sucesso!");
            }
            else
                Console.WriteLine("Falha ao inserir, verifique os dados!");
        }

        private void Export()
        {
            if(doctorController.ExportToTextFile())
            {
                Console.WriteLine("Arquivo gerado com sucesso!");
            }
            else
                Console.WriteLine("Oooops... Notthing");
        }
        private void Import()
        {
            if(doctorController.ImportFromTxtFile())
            {
                Console.WriteLine("Dados importados com sucesso!");
            }
            else
                Console.WriteLine("Oooops... Notthing");
        }

    }
    
}