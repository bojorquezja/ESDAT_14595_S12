using System;
using Lista_Adyacencia;

namespace Lista_Adyacencia_PND
{
    public class Program
    {
        public static void Main(string[] args)
        {

            GrafoPND a = new GrafoPND(3);

            a.AgregarVertice(0, 'A');
            a.AgregarVertice(1, 'B');
            a.AgregarVertice(2, 'C');

            a.Agregar('A','B', 10);
            a.Agregar('A','C', 20);
            a.Agregar('B', 'A', 5);
            a.Agregar('C','A', 5);
            a.mostrar();
        }
    }
}