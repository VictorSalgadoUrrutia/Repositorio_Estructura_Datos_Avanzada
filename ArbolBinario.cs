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
        }



    }

