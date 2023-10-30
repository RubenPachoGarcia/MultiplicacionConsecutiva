using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicacionConsecutiva.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int pedirNum()
        {
            int n1;
            Console.WriteLine("Introduzca un numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            return n1;

        }
        public int multiplicacion(int i)
        {
            int multiplicacion = 1;

            for (int n2 = 1; n2 <= i; n2++)
            {
                multiplicacion *= n2;

            }

            Console.WriteLine("El resultado es: " + multiplicacion);
            return multiplicacion;

        }
        public int preguntarUsuario()
        {
            int opcionIntroducida;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1. Cerra aplicacion");
            Console.WriteLine("2. Continuar usando la aplicacion");
            Console.WriteLine("--------------------------------------");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            return opcionIntroducida;


        }
        
            

        
    }
}
