using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootCamp_Challenge_8.Ejercicio_2;
using BootCamp_Challenge_8.Ejercicio_3;
using BootCamp_Challenge_8.Ejercicio_1;

namespace BootCamp_Challenge_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio1(); //// Singleton
            //Ejercicio2(); //// Factory Metod
            //Ejercicio3(); //// Prototype,
            Console.ReadKey();
        }
        
        static void Ejercicio1()
        {
            Paises.getCountries();
            Paises.addCountries("Argentina");
            Paises.addCountries("Brasil");
            Paises.getCountries();
        }

        static void Ejercicio2()
        {
            ConectionFactory coneccionOracle = Conectar.conectar(Conectar.ORACLE);
            ConectionFactory coneccionSQL = Conectar.conectar(Conectar.SQL);
            ConectionFactory coneccionMySQL = Conectar.conectar(Conectar.MySQL);

            coneccionOracle.Getconnect();
            coneccionSQL.Getconnect();
            coneccionMySQL.Getconnect();
        }

        static void Ejercicio3()
        {
            CajaAhorro uno = new CajaAhorro("Felix", 32079491);
            CajaAhorro dos = uno;
            dos.Numero = 1111;
            Console.WriteLine(uno.ToString());
            Console.WriteLine(dos.ToString());

            CajaAhorro unoClonado = new CajaAhorro("FelixClonado", 32079491);
            CajaAhorro dosClonado = unoClonado.Clone() as CajaAhorro;
            dosClonado.Numero = 1111;
            Console.WriteLine(unoClonado.ToString());
            Console.WriteLine(dosClonado.ToString());
        }
    }
}
