using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumeroPorExtenso
{
    public class Centena
    {
      public string CentenaPorExtenso(int numero)
        {
            string retorno = "";
            Unidade unidade = new Unidade();
            Dezena dezena = new Dezena();


            if(numero >= 100 && numero <= 199)
            {
                if(numero == 100)
                 retorno = "Cem";
                if(numero >= 101 && numero <= 109)
                {
                    string und = numero.ToString().Substring(1,2);
                    retorno = "cento e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
                else
                {
                    string dzn = numero.ToString().Substring(1,2);
                    retorno = "cento e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(dzn));
                    Console.WriteLine(dzn);
                }
            }
            return retorno;
        }
          
    }
}