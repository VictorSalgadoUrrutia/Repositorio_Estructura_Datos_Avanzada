using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{

    class ArbolBinario
    {
        private Nodo raiz;
        public ArbolBinario()
        {
            raiz = null;
        }
        public void Insertar(int valor)
        {
            if (raiz == null)
            {
                raiz = new Nodo(valor);
            }
            else
            {
                InsertarEnSubarbol(raiz, valor);
            }
        }
        public void InsertarEnSubarbol(Nodo nodo, int valor)
        {
            if (valor < nodo.Valor)
            {
                if (nodo.NodoIzquierdo == null)
                {
                    nodo.NodoIzquierdo = new Nodo(valor);
                }
                else
                {
                    InsertarEnSubarbol(nodo.NodoIzquierdo, valor);
                }
            }
            else
            {
                if (nodo.NodoDerecho == null)
                {
                    nodo.NodoDerecho = new Nodo(valor);
                }
                else
                {
                    InsertarEnSubarbol(nodo.NodoDerecho, valor);
                }
            }
        }
        public bool Buscar(int valor)
        {
            return BuscarEnSubarbol(raiz, valor);
        }

        private bool BuscarEnSubarbol(Nodo nodo, int valor)
        {
            if (nodo == null)
            {
                return false;
            }
            if (valor == nodo.Valor)
            {
                return true;
            }
            if (valor < nodo.Valor)
            {
                return BuscarEnSubarbol(nodo.NodoIzquierdo, valor);
            }
            else
            {
                return BuscarEnSubarbol(nodo.NodoDerecho, valor);
            }
        }
        public int ObtenerNivel(int valor)
        {
            return ObtenerNivelEnSubarbol(raiz, valor, 1);
        }


        private int ObtenerNivelEnSubarbol(Nodo nodo, int valor, int nivelActual)
        {
            if (nodo == null)
            {
                Console.WriteLine("El nodo no se encontro en el arbol. ");
                return -1;
            }
            if(valor == nodo.Valor)
            {
                Console.WriteLine("El nodo se encuentra en el nivel: "+nivelActual);
                return nivelActual;
            }
            if(valor < nodo.Valor)
            {
                return ObtenerNivelEnSubarbol(nodo.NodoIzquierdo, valor, nivelActual + 1);
            }
            else
            {
                return ObtenerNivelEnSubarbol(nodo.NodoDerecho, valor, nivelActual + 1);
            }
        }
        public void RecorrerCaminos()
        {
            RecorrerCaminosEnSubarbol(raiz, "");
        }
        private void RecorrerCaminosEnSubarbol(Nodo nodo, string caminoActual)
        {
        if (nodo == null)
        {
            return;
        }
        caminoActual += nodo.Valor.ToString() + "";
        if (nodo.NodoIzquierdo == null && nodo.NodoDerecho == null && nodo.NodoDerecho == null)
        {
            Console.WriteLine(caminoActual);
        }
            Console.WriteLine(caminoActual);
            RecorrerCaminosEnSubarbol(nodo.NodoIzquierdo, caminoActual);
            RecorrerCaminosEnSubarbol(nodo.NodoDerecho, caminoActual);
        }
    }

}

    

