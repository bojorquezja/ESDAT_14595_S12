using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Adyacencia
{
    internal class GrafoPND
    {
        private Lista[] Lista_A;
        private char[] vertices;

        public GrafoPND(int cantidadPND)
        {
            Lista_A = new Lista[cantidadPND];
            vertices = new char[cantidadPND];

            for (int i = 0; i < cantidadPND; i++)
            {
                Lista_A[i] = new Lista();
                vertices[i] = '\0'; 
            }
        }

        public void AgregarVertice(int posicion, char marca)
        {
            vertices[posicion] = marca;
        }
        public void Agregar(char origen, char destino, int peso)
        {
            int iOrigen = BuscarMarca(origen);
            int iDestino = BuscarMarca(destino);

            if (iOrigen == -1 || iDestino == -1)
            {
                Console.WriteLine("No existe la marca");
                return;
            }

            Lista_A[iOrigen].insertar(iDestino, peso);
        }
        public void mostrar()
        {
            int i = 0;
            foreach(Lista elemento in Lista_A)
            {
                Console.WriteLine($"Lista {i}:");
                elemento.mostrar(vertices);
                i++;
            }
        }
        public int BuscarMarca(char marca)
        {
            for (int i = 0; i < vertices.Length; i++)
            {
                if (vertices[i] == marca)
                    return i;
            }

            return -1;
        }
    }
}
