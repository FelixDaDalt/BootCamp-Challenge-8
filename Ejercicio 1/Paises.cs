using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp_Challenge_8.Ejercicio_1
{
    class Paises
    {
        private static Paises instancia = null;
        protected static List<string> paises;
  
        
        protected Paises(List<string> lpaises)
        { 
            paises = lpaises;
        }
        protected Paises() { }

        public static void getCountries()
        {
            if(instancia == null)
            {
                instancia = new Paises(new List<string>());
            }

            for(int i = 0; i < paises.Count; i++)
            {
                Console.WriteLine($"{i} - {paises[i]}");
            }
        }

        public static void addCountries(string nombre)
        {
            if (instancia == null)
            {
                getCountries();
            }
            paises.Add(nombre);
        }



    }
}
