using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class Varios
    {
        public bool validar(string nomb, string gene, string desa, string publ, string clas, decimal rati, decimal prec)
        {

            if ((!nomb.Equals("") && nomb.Length <= 50) &&
                (!gene.Equals("") && nomb.Length <= 50) &&
                (!desa.Equals("") && nomb.Length <= 50) &&
                (!publ.Equals("") && nomb.Length <= 50) &&
                (!clas.Equals("") && nomb.Length <= 30) &&
                (prec >= (decimal)0.00 && prec <= (decimal)9999999999.99) &&
                (rati >= (decimal)0.00) && rati <= (decimal)9.99)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
