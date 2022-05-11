using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp_Challenge_8.Ejercicio_2
{
    class Conectar
    {
        public const int SQL = 1;
        public const int MySQL = 2;
        public const int ORACLE = 3;

        public static ConectionFactory conectar(int tipo)
        {
            switch(tipo)
            {
                case SQL:
                return new ConexionSQL();

                case MySQL:
                return new ConexionMysql();

                case ORACLE:
                return new ConecionOracle();

               default: return null;
            }
        }
    }
}
