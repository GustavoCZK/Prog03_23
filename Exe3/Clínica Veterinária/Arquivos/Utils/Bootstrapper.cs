using Arquivos.Models;
using Arquivos.Data;

namespace Arquivos.Utils
{
    public class Bootstrapper
    {

        public static void Charger()
        {
            ChargeClients();
            ChargeAnimals();
            ChargeDoctors();
            ChargeClinics();
        }

        public static void ChargeClients()
        {
            DataSet.Clients.Add(
                new Client{
                    Id = 1,
                    FirstName = "Mauricio Roberto",
                    LastName = "Gonzatto",
                    CPF = "000.000.000.00",
                    Email = "tralalatra@tata.tu.cr"
                }
            );

            DataSet.Clients.Add(
                new Client{
                    Id = 2,
                    FirstName = "Eduardo",
                    LastName = "Blank",
                    CPF = "000.000.000.01",
                    Email = "tropetrup@tata.tu.cr"
                }
            );

            DataSet.Clients.Add(
                new Client{
                    Id = 3,
                    FirstName = "Aguinaldo",
                    LastName = "Tímoteo",
                    CPF = "000.000.000.02",
                    Email = "frangfru@tata.tu.cr"
                }
            );
            
        }

        public static void ChargeAnimals()
        {
            DataSet.Animals.Add(
                new Animal{
                    Id = 1,
                    Name = "Flopy",
                    Sexo = "Macho",
                    Tipo = "Gato"
                }
            );

            DataSet.Animals.Add(
                new Animal{
                    Id = 2,
                    Name = "Amora",
                    Sexo = "Fêmea",
                    Tipo = "Cachorro"
                }
            );

            DataSet.Animals.Add(
                new Animal{
                    Id = 3,
                    Name = "Venom",
                    Sexo = "Macho",
                    Tipo = "Cobra"
                }
            );
            
        }

        public static void ChargeDoctors()
        {
            DataSet.Doctors.Add(
                new Doctor{
                    Id = 1,
                    FirstName = "Mauricio Roberto",
                    LastName = "Gonzatto",
                    CPF = "000.000.000.00",
                    Email = "tralalatra@tata.tu.cr",
                    ClinicName = "São Paulo"
                }
            );

            DataSet.Doctors.Add(
                new Doctor{
                    Id = 2,
                    FirstName = "Eduardo",
                    LastName = "Blank",
                    CPF = "000.000.000.01",
                    Email = "tropetrup@tata.tu.cr",
                    ClinicName = "Saturno"
                }
            );

            DataSet.Doctors.Add(
                new Doctor{
                    Id = 3,
                    FirstName = "Aguinaldo",
                    LastName = "Tímoteo",
                    CPF = "000.000.000.02",
                    Email = "frangfru@tata.tu.cr",
                    ClinicName = "PetLove"
                }
            );
            
        }
        public static void ChargeClinics()
        {
            DataSet.Clinics.Add(
                new Clinic{
                    Id = 1,
                    Name = "LoveAnimals",
                    Telefone = "(79)99556-4165",
                    Endereco = "Belo Horizonte, Av. Longe Pacas, 174"
                }
            );

            DataSet.Clinics.Add(
                new Clinic{
                    Id = 2,
                    Name = "PetShower",
                    Telefone = "(56)96512-4584",
                    Endereco = "Figueira, R. Perto Pacas, 9900"
                }
            );

            DataSet.Clinics.Add(
                new Clinic{
                    Id = 3,
                    Name = "PetNess",
                    Telefone = "(12)96571-7329",
                    Endereco = "Brasilia, R. Turma Animal, 851"
                }
            );
            
        }
    }
}