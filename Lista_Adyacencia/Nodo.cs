using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Adyacencia
{
    internal class Nodo
    {
        private int dirección;
        private int peso;
        private Nodo siguiente;
    
        public int Dirección { get => dirección; set => dirección = value; }
        public int Peso { get => peso; set => peso = value; }
        internal Nodo Siguiente { get => siguiente; set => siguiente = value; }

    }
}
