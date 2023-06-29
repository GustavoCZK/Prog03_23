namespace Arquivos.Models
{
    public class Animal
    {
        public string? Name {get; set;}
        public string? Tipo {get; set;}
        public int Id {get; set;}
        public string? Sexo {get; set;}

        public Animal()
        {
            
        }
        public Animal(string? name, string? tipo, int id, string? sexo)
        {
            Name = name;
            Tipo = tipo;
            Id = id;
            Sexo = sexo;
        }

        public override string ToString()
        {
            return $"Id: {this.Id} \nName: {this.Name} \nTipo: {this.Tipo} \nSexo: {this.Sexo}";
        }
    }
}