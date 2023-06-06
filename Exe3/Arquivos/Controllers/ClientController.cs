using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Controllers
{
    public class ClientController
    {
        public int GetNextId()
        {
            int tam = DataSet.Clients.Count + 1;

            if(tam > 0)
            {
                return DataSet.Clients[tam - 1].Id + 1;
            }
            else
                return 1;
        }        
    }
}