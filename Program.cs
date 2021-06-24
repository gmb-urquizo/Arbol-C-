using System;

namespace Arbol
{
    partial class Program
    {
        static void Main(string[] args)
        {
            ImprimirArbol(SimulacionArbol.Raiz, string.Empty);
            Console.Read();
        }

        public static void ImprimirArbol(Nodo raiz, string indent)
        {
            if (raiz.Izquierda !=null)
            {
                ImprimirArbol(raiz.Izquierda, indent + "\t");
            }

            Console.WriteLine(indent + raiz.Valor);

            if (raiz.Derecha != null)
            {
                ImprimirArbol(raiz.Derecha, indent + "\t");
            }
        }
    }
}
