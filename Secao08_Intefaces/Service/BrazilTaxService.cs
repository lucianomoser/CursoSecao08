using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao08_Intefaces.Service
{
    public class BrazilTaxService:ITaxService
    {
        public double Tax(double amount)
        {
            if (amount < 100.00)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
            
        }
    }
}
