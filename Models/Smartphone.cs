using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__POO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }

        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }
     


        public Smartphone(){}
          
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            this.Numero = numero;
            this.Modelo = modelo;
            this.IMEI = imei;
            this.Memoria = memoria;

        }
         
          public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }


        public abstract void ModeloCel(string numero, string modelo, string imei, int memoria);
        public abstract void InstalarAplicativo(string nomeApp);
         
       
    }
}