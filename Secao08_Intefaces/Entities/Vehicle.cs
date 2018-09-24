using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao08_Intefaces.Entities
{
    class Vehicle
    {
        public string model { get; set; }

        public Vehicle(string model)
        {
            this.model = model;
        }
    }
}
