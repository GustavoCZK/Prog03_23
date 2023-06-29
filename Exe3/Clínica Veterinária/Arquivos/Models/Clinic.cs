using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Models
{
    public class Clinic
    {
        public int Id {get; set;}
        public string? Name {get; set;}
        public string? Endereco {get; set;}
        public string? Telefone {get; set;}

        public Clinic()
        {
            
        }

        public Clinic(int id, string? name, string? endereco, string? telefone)
        {
            Id = id;
            Name = name;
            Endereco = endereco;
            Telefone = telefone;
        }

        public override string ToString()
        {
            return $"Id: {this.Id} \nName: {this.Name} \nTipo: {this.Telefone} \nSexo: {this.Endereco}";
        }
    }
}