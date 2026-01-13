namespace TareaListas
{
    public class Nodo
    {
        public int Dato { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(int dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
//ListaEnlazada.cs

using System;

namespace TareaListas
{
    public class ListaEnlazada
    {
        private Nodo primero;

        public ListaEnlazada()
        {
            primero = null;
        }

        public void Insertar(int dato)
        {
            Nodo nuevo = new Nodo(dato);
            if (primero == null) { primero = nuevo; }
            else
            {
                Nodo actual = primero;
                while (actual.Siguiente != null) { actual = actual.Siguiente; }
                actual.Siguiente = nuevo;
            }
        }

        // EJERCICIO 1: Contar elementos
        public int ContarElementos()
        {
            int contador = 0;
            Nodo actual = primero;
            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }
            return contador;
        }

        // EJERCICIO 3: Buscar dato y contar ocurrencias
        public void BuscarDato(int valor)
        {
            int contador = 0;
            Nodo actual = primero;
            while (actual != null)
            {
                if (actual.Dato == valor) { contador++; }
                actual = actual.Siguiente;
            }

            if (contador > 0)
                Console.WriteLine($"\nEl dato {valor} se encontro {contador} veces en la lista.");
            else
                Console.WriteLine($"\nEl dato {valor} no fue encontrado en la lista.");
        }

        public void MostrarLista()
        {
            Nodo actual = primero;
            Console.Write("Lista: ");
            while (actual != null)
            {
                Console.Write($"[{actual.Dato}] -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("NULL");
        }
    }
}
//Program.cs
using System;

namespace TareaListas
{
    class Program
    {
        static void Main(string[] args)
        {
            // DATOS DEL ESTUDIANTE
            Console.WriteLine("ESTUDIANTE: JEFFERSON");
            Console.WriteLine("TAREA: LISTAS ENLAZADAS - SEMANA 6");
            Console.WriteLine("EJERCICIOS ELEGIDOS: 1 y 3\n");

            ListaEnlazada miLista = new ListaEnlazada();

            // Insertando algunos datos de prueba
            miLista.Insertar(10);
            miLista.Insertar(20);
            miLista.Insertar(10);
            miLista.Insertar(30);

            miLista.MostrarLista();

            // PRUEBA EJERCICIO 1
            int total = miLista.ContarElementos();
            Console.WriteLine($"\n1. TOTAL DE ELEMENTOS: {total}");

            // PRUEBA EJERCICIO 3
            Console.Write("\nIngrese un numero para buscar en la lista: ");
            int buscar = int.Parse(Console.ReadLine());
            miLista.BuscarDato(buscar);

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
  

      





