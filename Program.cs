using System;

namespace TareaListas
{
    // 1. ESTRUCTURA DEL NODO
    public class Nodo
    {
        public int Dato { get; set; }
        public Nodo Siguiente { get; set; }
        public Nodo(int dato) { Dato = dato; Siguiente = null; }
    }

    // 2. CLASE LISTA ENLAZADA (CON EJERCICIOS 1 Y 3)
    public class ListaEnlazada
    {
        private Nodo primero;
        public ListaEnlazada() { primero = null; }

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

        // EJERCICIO 1: Calcular número de elementos
        public int ContarElementos()
        {
            int contador = 0;
            Nodo actual = primero;
            while (actual != null) { contador++; actual = actual.Siguiente; }
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
                Console.WriteLine($"\nRESULTADO: El dato {valor} se encontro {contador} veces.");
            else
                Console.WriteLine($"\nRESULTADO: El dato {valor} no fue encontrado.");
        }

        public void MostrarLista()
        {
            Nodo actual = primero;
            Console.Write("Contenido de la lista: ");
            while (actual != null) { Console.Write($"[{actual.Dato}] -> "); actual = actual.Siguiente; }
            Console.WriteLine("NULL");
        }
    }

    // 3. PROGRAMA PRINCIPAL
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("TAREAS DE LISTAS ENLAZADAS - JEFFERSON");
            Console.WriteLine("EJERCICIOS SELECCIONADOS: 1 y 3");
            Console.WriteLine("===========================================\n");

            ListaEnlazada miLista = new ListaEnlazada();

            // Insertamos datos de prueba
            miLista.Insertar(10);
            miLista.Insertar(25);
            miLista.Insertar(10);
            miLista.Insertar(40);
            miLista.Insertar(10);

            miLista.MostrarLista();

            // Ejecución Ejercicio 1
            Console.WriteLine($"\nEJERCICIO 1: Total de elementos en la lista: {miLista.ContarElementos()}");

            // Ejecución Ejercicio 3
            Console.WriteLine("\nEJERCICIO 3: Busqueda del numero 10...");
            miLista.BuscarDato(10);

            Console.WriteLine("\nPresione cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}



     
       
        
           
               
    

           
           

           

      






