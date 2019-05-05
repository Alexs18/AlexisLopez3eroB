using System;

namespace TAD_LISTA
{
    class Lista
    {
        int dat = 0;
        private Nodo Primero;
        private int size;
        public Lista()
        {
            this.Primero= null;
            this.size = 0;
        }
        public void Vacia()
        {
            if (Primero==null)
            {
                Console.WriteLine("LA LISTA ESTA VACIA");
            }
            else
            {
                Console.WriteLine("LA LISTA CONTIENE DATOS");
            }
        }
        public void InsertarDato(int dato)
        {
            Nodo Nuevo = new Nodo(dato);
            Nuevo.siguiente = Primero;
            Primero = Nuevo;
            size++;
        }
        public int Size()
        {
            return size;
        }
        public void Visualizar()
        {
            Nodo actual = Primero;
            while (actual!=null)
            {
                Console.WriteLine("[" + actual.dato + "]");
                actual = actual.siguiente;
            }
        }
        static void Main(string[] args)
        {
            Lista Lista = new Lista();
            Lista.Vacia();
            Lista.InsertarDato(1);
            Lista.InsertarDato(2);
            Lista.InsertarDato(3);
            Lista.InsertarDato(5);
            Lista.InsertarDato(7);
            Lista.Visualizar();
            Console.WriteLine("EL TAMAÑO ES " + Lista.Size());
            Lista.Vacia();
            Console.ReadKey();
        }
    }
}
