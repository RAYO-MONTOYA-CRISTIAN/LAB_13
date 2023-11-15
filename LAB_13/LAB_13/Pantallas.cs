using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_13
{
    public class Pantallas
    {
        public static int [] voto = new int[100];
        public static int contador = 0;

        public static int Menu()
        {
            string texto = "================================\n" +
                         "Encuestas de Calidad\n" +
                         "================================\n" +
                         "1: Realizar Encuesta\n" +
                         "2: Ver datos registrados\n" +
                         "3: Eliminar un dato\n" +
                         "4: Ordenar datos de menor a mayor\n" +
                         "5: Salir\n" +
                         "================================\n";
            Console.Write(texto);
            return Operaciones.getEntero("Ingrese una opción: ", texto);

        }
        public static int NiveldeSatisfacción()
        {

            string texto = " ================================\n" +
                    "Nivel de Satisfacción\n" +
                    "================================\n" +
                    "¿Qué tan satisfecho está con la\n" +
                    "atención de nuestra tienda?\n" +
                    "1: Nada satisfecho\n" +
                    "2: No muy satisfecho\n" +
                    "3: Tolerable\n" +
                    "4: Satisfecho\n" +
                    "5: Muy satisfecho\n" +
                    "================================\n";
            Console.Write(texto);
            int Voto = Operaciones.getENTERO("Ingrese una opción: ");

            if (contador == 100)
            {
                Console.WriteLine("LA LISTA YA ESTÁ LLENA");

            }
            else
            {

                voto[contador] = Voto;
                contador++;
                
            }
            Console.Clear();
            return GraciasPorParticipar();
            
        }
        public static int GraciasPorParticipar()
        {
            string texto = " ================================\n" +
                    "Nivel de Satisfacción\n" +
                    "================================\n" +
                    "\n" +
                    "\n" +
                    "¡Gracias por participar!\n" +
                    "\n" +
                    "\n" +
                    "================================\n" +
                    "1: Regresar al menú\n" +
                    "================================\n";
            Console.Write(texto);

            int opcion = Operaciones.getEntero("Ingrese una opción: ", texto);
            if (opcion == 1) return 0;
            return opcion;
        }
        public static int DatosRegistrados()
        {
            string texto = "================================\n" +
                "Ver datos registrados\n" +
                "================================\n";

            Console.Write(texto);

            if (contador == 0)
            {
                Console.WriteLine("No extisten notas");
            }
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine("->" + voto[i]);
            }
            string texto2 = "================================\n" +
                    "1 = Nada satisfecho\n" +
                    "2 = No muy satisfecho\n" +
                    "3 = Tolerable\n" +
                    "4 = Satisfecho\n" +
                    "5 = Muy satisfecho\n" +
                    "================================\n";

            Console.Write(texto2);
            int[] conteoPorOpcion = new int[6];

            for (int i = 0; i < contador; i++)
            {
                int OPCION = voto[i];

                
                conteoPorOpcion[OPCION]++;
            }

            for (int i = 1; i < conteoPorOpcion.Length; i++)
            {
                Console.WriteLine($"{i}: {conteoPorOpcion[i]} personas");
            }

            string texto3 = "================================\n" +
                "1: Regresar\n"+
                "================================\n";

            Console.Write(texto3);

            int opcion = Operaciones.getEntero("Ingrese una opción: ", texto);
            if (opcion == 1) return 0;
            return opcion;
        }
        public static int EliminarDato()
        {

            string texto = "================================\n" +
                "Eliminar un dato\n" +
                "================================\n";
            Console.Write(texto);

            Console.Write("Ingrese la posición a eliminar: ");
            int posicion = int.Parse(Console.ReadLine());

            if (posicion >= 0 && posicion < voto.Length)
            {
                int i;

                for (i = posicion; i < contador - 1; i++)
                {
                    voto[i] = voto[i + 1];
                }
                contador = contador - 1;

            }
            else
            {
                Console.WriteLine("La posición ingresada no es válida.");
            }


            string texto2 = "================================\n" +
               "1: Regresar\n"+
               "================================\n";

            Console.Write(texto2);


            int opcion = Operaciones.getEntero("Ingrese una opción: ", texto);
            if (opcion == 1) return 0;
            return opcion;
        }
        public static int OrdenarDatos()
        {
            string texto = "================================\n" +
                "Ordenar datos de menor a mayor\n" +
                "================================\n";
            Console.Write(texto);
            int ordenado = 0;
            while(ordenado == 0)
                ordenado = 1;

            int i;

            for(i = 0; i < contador -1; i++)
            {
                if (voto[i] > voto[i + 1])
                {
                    int aux = voto[i];
                    voto[i] = voto[i + 1];
                    voto[i + 1] = aux;
                    ordenado = 0;

                }

            }
            string texto2 = "================================\n" +
               "1: Regresar\n" +
               "================================\n";

            Console.Write(texto2);


            int opcion = Operaciones.getEntero("Ingrese una opción: ", texto);
            if (opcion == 1) return 0;
            return opcion;
        }
    }
}
