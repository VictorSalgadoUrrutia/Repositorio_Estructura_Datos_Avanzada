using System;

namespace Arboles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario arbol = new ArbolBinario();

            // Insertar números en el árbol
            arbol.Insertar(5);
            arbol.Insertar(3);
            arbol.Insertar(8);
            arbol.Insertar(1);
            arbol.Insertar(4);
            arbol.Insertar(7);
            arbol.Insertar(9);
            Console.WriteLine(arbol.Buscar(7));
            Console.WriteLine(arbol.Buscar(5));
            arbol.ObtenerNivel(8);
            arbol.RecorrerCaminos();
        }
    }
}
