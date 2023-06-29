using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Models
{
    public class Doctor
    {
        public string? FirstName {get; set;}
        public string? LastName {get; set;}
        public string? CPF {get; set;}
        public int Id {get; set;}
        public string? Email {get; set;}
        public string? ClinicName {get; set;}

        //Método SEMPRE utiliza ().
        
        // Os métodos contrutores são responsáveis por instanciar uma variável do tipo especificado pela classe.
        // A regra é de que o construtor tenha o mesmo nome da classe.
        public Doctor()
        {

        }
        public Doctor(string? firstName, string? lastName, string? cPF, int id, string email, string clinicName)
        {  // Início do escopo deste método...  
            FirstName = firstName;
            LastName = lastName;
            CPF = cPF;
            Id = id;
            Email = email;
            ClinicName = clinicName;
        } // Fim do escopo deste método...

        public string FullName => $"{this.FirstName} {this.LastName}";

        public override string ToString()
        {
            return $"Id: {this.Id} \nName: {this.FullName} \nCPF: {this.CPF} \nEmail: {this.Email} \nTrabalha na Clínica: {this.ClinicName}";
        }
    }
}