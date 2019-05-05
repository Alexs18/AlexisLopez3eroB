using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TAD_PILA._2
{
    class pila
    {
        public static void Main(string[] args)
        {
            Stack Pila = new Stack();

            int boton;
            do
            {
                Console.WriteLine("  ");
                Console.WriteLine("    BIENVENIDO \n" +
                           "AL MENU PILA\n" +
                    "\n 1.- Agregar Elemento A la Pila" +
                    "\n 2- ELiminar Elementos de la Pila" +
                     "\n 3. Cima\n"+
                      "\n 4.-salir\n");

                Console.WriteLine("DIGITE SU OPCCION\n");
                boton = Convert.ToInt32(Console.ReadLine());

                switch (boton)
                {
                    case 1:
                        Apilar(ref Pila);

                        break;

                    case 2:
                        Desapilar(ref Pila);


                        break;
                    case 3:
                        Cima(ref Pila);
                        break;
                    case 4: 
                        
                }
            } while (boton != 4);
            Console.ReadKey();

        }
        public static void Apilar(ref Stack pila)
        {
            Console.WriteLine("INGRESE ELEMENTO A LA PILA "); int num = Convert.ToInt32(Console.ReadLine());
            pila.Push(num);

        }
        public static void Desapilar(ref Stack pila)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());

            pila.Clear();
            Console.WriteLine("Su Pila a sido vaciada");
        }
        public static void Cima(ref Stack pila)
        {

            int num = 0;


            Console.WriteLine("EL Ultimo valor de la pila es ");
            Console.WriteLine(num = (int)pila.Pop());

        }
    }
}

