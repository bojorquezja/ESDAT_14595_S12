using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Adyacencia
{
    internal class Lista
    {
        private Nodo primero = null;
        private Nodo ultimo = null;

        public void insertar(int direccion, int peso)
        {
            Nodo nuevo = new Nodo(); 
            nuevo.Dirección = direccion;
            nuevo.Peso = peso;

            if (primero == null)
            {
                primero = nuevo;
                primero.Siguiente = null;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                ultimo = nuevo;
            }
        }

        public void mostrar(char[] vertices)
        {
            Nodo actual = primero;

            while (actual != null)
            {
                Console.WriteLine($" {vertices[actual.Dirección]} / Peso: {actual.Peso}");
                
               actual = actual.Siguiente;
            }
        }

    }
}
