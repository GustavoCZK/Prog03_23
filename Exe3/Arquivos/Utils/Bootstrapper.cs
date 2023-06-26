using Arquivos.Models;
using Arquivos.Data;

namespace Arquivos.Utils
{
    public class Bootstrapper
    {
        public static void ChargeClients()
        {
            var c1 = new Client{
                Id = 1,
                FirstName = "Mauricio Roberto",
                LastName = "Gonzatto",
                CPF = "000.000.000.00",
                Email = "tralalatra@tata.tu.cr"
                
            };
            DataSet.Clients.Add(c1);

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
    }
}