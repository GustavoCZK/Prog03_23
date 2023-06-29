using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Controllers;
using Arquivos.Models;
using Arquivos.Searchs;

namespace Arquivos.Views
{
    public class ClinicView
    {
        private ClinicController clinicController;

        public ClinicView()
        {
            clinicController = new ClinicController();
            this.Init();
        }
        public void Init()
        {
            Console.WriteLine("**********************");
            Console.WriteLine("Você está em Clínicas.");
            Console.WriteLine("**********************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir Clínicas");
            Console.WriteLine("2 - Listar Clínicas");
            Console.WriteLine("3 - Exportar Clínicas");
            Console.WriteLine("4 - Importar Clínicas");
            Console.WriteLine("5 - Pesquisar Clínicas");
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
                    ClinicSearch clinicSearch = new ClinicSearch();
                break;

                default:
                break;
            }
            
        }

        private void List()
        {
            List<Clinic> listagem = clinicController.List();
            //Controlador + Acumulador + Flag
            for(int i = 0; i < listagem.Count; i++)
            {
                Console.WriteLine(Print(listagem[i]));
            }
        }

        private string Print(Clinic clinic)
        {
            string retorno = "";
            retorno += $"Id: {clinic.Id} \n";
            retorno += $"Nome: {clinic.Name}\n";
            retorno += $"Telefone: {clinic.Telefone} \n";
            retorno += $"Endereço: {clinic.Endereco} \n";
            retorno += "------------------------------------------- \n";

            return retorno;
        }


        private void Insert()
        {
            Clinic clinic = new Clinic();
            clinic.Id = clinicController.GetNextId();

            Console.WriteLine("\nInforme O Nome da Clínica: ");
            clinic.Name = Console.ReadLine();

            Console.WriteLine("\nInforme O Telefone da Clínica: ");
            clinic.Telefone = Console.ReadLine();
            
            Console.WriteLine("\nInforme O Endereço da Clínica ");
            clinic.Endereco = Console.ReadLine();

            bool retorno = clinicController.Insert(clinic);

            if(retorno == true)
            {
                Console.WriteLine("Clínica inserido com sucesso!");
            }
            else
                Console.WriteLine("Falha ao inserir, verifique os dados!");
        }

        private void Export()
        {
            if(clinicController.ExportToTextFile())
            {
                Console.WriteLine("Arquivo gerado com sucesso!");
            }
            else
                Console.WriteLine("Oooops... Notthing");
        }
        private void Import()
        {
            if(clinicController.ImportFromTxtFile())
            {
                Console.WriteLine("Dados importados com sucesso!");
            }
            else
                Console.WriteLine("Oooops... Notthing");
        }
    }
}