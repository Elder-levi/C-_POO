using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__POO.Models
{
    public abstract class Conta
    {

        protected decimal Saldo;

        public abstract void Creditar(decimal valor); 

        public void ExicibirSaldo()
        {
            Console.WriteLine($"O seu saldo é {Saldo}");
        }
       


    }
}