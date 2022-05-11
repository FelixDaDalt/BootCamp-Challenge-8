using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp_Challenge_8.Ejercicio_3
{
    internal class SeguroDeVida : ICloneable
    {
        private string cliente;

        public SeguroDeVida(string cliente)
        {
            this.cliente = cliente;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
