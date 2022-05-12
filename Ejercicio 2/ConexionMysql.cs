using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp_Challenge_8.Ejercicio_2
{
    class ConexionMysql : ConectionFactory
    {
        public void Getconnect()
        {
            Console.WriteLine("Conectando a MySQL");
        }
    }
}
