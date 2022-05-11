using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp_Challenge_8.Ejercicio_3
{
    class CajaAhorro : ICloneable
    {
        private string cliente;
        private int numero;
        
        public int Numero { get => numero; set => numero = value; }
        public string Cliente { get => cliente; set => cliente = value; }

        public CajaAhorro(string cliente, int numero)
        {
            this.cliente = cliente;
            this.numero = numero;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"CLiente: {Cliente} - Numero: {Numero}";
        }
    }
}
