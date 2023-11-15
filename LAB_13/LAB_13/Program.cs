using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = Pantallas.Menu();
            do
            {
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        opcion = Pantallas.NiveldeSatisfacción();
                        break;
                    case 2:
                        opcion = Pantallas.DatosRegistrados();
                        break;
                    case 3:
                        opcion = Pantallas.EliminarDato();
                        break;
                    case 4:
                        opcion = Pantallas.OrdenarDatos();
                        break;
                    case 0:
                    default:
                        opcion = Pantallas.Menu();
                        break;
                }
            } while (opcion != 5);

        }
    }
}
