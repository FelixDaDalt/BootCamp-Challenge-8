using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp_Challenge_8.Ejercicio_1
{
    class Provincia : Paises
    {
        static Provincia instancia = null;
        static string [] paisesARR = paises.ToArray();
        static List<string> provinciasLista = new List<string> ();

        protected Provincia()
        {

        }

        public static void getProvincias(int pais)
        {
            if(instancia == null)
            {
                instancia = new Provincia();
            }
            if (pais < paisesARR.Length)
            {
                string paises = paisesARR[pais];

                foreach (string value in provinciasLista)
                {
                    if (value.Contains(paises))
                    {
                        Console.WriteLine(value);
                    }
                }
            }
            else { Console.WriteLine($"No existe Pais {pais} para mostrar sus provincia"); }
        }

        public static void addProvincia(int pais, string provincia)
        {
            if (instancia == null)
            {
                instancia = new Provincia();
            }
            if (pais < paisesARR.Length)
            { 
                string paises = paisesARR[pais];
                provinciasLista.Add($"{paises},{provincia}");
            }
            else { Console.WriteLine($"No existe Pais: {pais} para Agregar: {provincia}"); }
        }

    }
}
