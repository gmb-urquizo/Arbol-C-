using System;


namespace Arbol
{
    public static class SimulacionArbol
    {
        public static Nodo Raiz
        {
            get
            {
                var arbol = new Nodo()
                {
                    Valor = "5",
                    Izquierda = new Nodo()
                    {
                        Valor = "+",
                        Izquierda = new Nodo()
                        {
                            Valor = "*",
                            Derecha = new Nodo()
                            {
                                Valor = "+",
                                Izquierda = new Nodo()
                                {
                                    Valor = "7",
                                },
                                Derecha = new Nodo()
                                {
                                    Valor = "4",
                                },
                            },
                            
                        },

                    },
                    Derecha = new Nodo()
                    {
                        Valor = "3",
                    },

                };

                return arbol;
            }
        }
    }
}
