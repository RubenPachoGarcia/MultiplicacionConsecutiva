using MultiplicacionConsecutiva.Servicios;
using System.Security.Cryptography.X509Certificates;

namespace MultiplicacionConsecutiva
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n1;

            MenuInterfaz mi = new MenuImplementacion();
            n1 = mi.pedirNum();                      
            n1 = mi.multiplicacion(n1);

            bool cerrarMenu = false;
            int opcionElegida;

            while (!cerrarMenu)
            {
                opcionElegida = mi.preguntarUsuario();
                Console.WriteLine(opcionElegida);

                switch (opcionElegida)
                {
                    case 1:
                        Console.WriteLine("[INFO] - Se cierra el menu.");
                        cerrarMenu = true;
                        break;

                    case 2:
                        mi.pedirNum();
                        mi.multiplicacion(n1);
                        break;
                }
            }
        }
    }
}
    

    
