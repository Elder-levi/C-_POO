using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace C__POO.Models
{
  
    public class Iphone : Smartphone
    {
        
         public override void ModeloCel(string numero, string modelo, string imei, int memoria)
        {
           Console.WriteLine($" Modelo: {modelo}\n Memoria: {memoria} \n Numero de Telefone:{numero}");
        }
          
        public override void InstalarAplicativo(string Nome)
        {
            Console.WriteLine($"Instalando.....{Nome}");
        }
    }
}