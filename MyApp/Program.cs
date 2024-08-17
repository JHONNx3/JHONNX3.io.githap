using System;
using System.Collections.Generic;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crea una lista de strings vacía para q puedas guardar los datos y tareas 
            List<string> myList = new List<string>();

            while (true)
            {
                Console.WriteLine("1. Agregar tarea");
                Console.WriteLine("2. Ver tareas");
                Console.WriteLine("3. Eliminar tarea");
                Console.WriteLine("4. Ver tareas completadas");
                Console.WriteLine("5. Marcar/Desmarcar tarea como completa");
                Console.WriteLine("6. Salir");

                // Lee la opción seleccionada por el usuario cuando este se llama 

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        // Agregar elemento a la lista para q se puedan usar 

                        Console.Write("Ingrese una tarea: ");
                        string elementToAdd = Console.ReadLine();
                        myList.Add(elementToAdd);
                        break;
                    case 2:
                        // Ver elementos en la lista los cuales guardaste 

                        if (myList.Count == 0)
                        {
                            Console.WriteLine("La lista está vacía");
                        }
                        else
                        {
                            foreach (string element in myList)
                            {
                                Console.WriteLine(element);
                            }
                        }
                        break;
                    case 3:

                        // Eliminar los elementos q guardste 

                        if (myList.Count > 0)
                        {
                            Console.Write("Ingrese el nombre de la tarea a eliminar: ");
                            string taskToDelete = Console.ReadLine();
                            myList.RemoveAll(t => t == taskToDelete);
                            Console.WriteLine("Tarea eliminada correctamente");
                        }
                        else
                        {
                            Console.WriteLine("La lista está vacia");
                        }
                        break;
                    case 4:
                        // Ver elementos completados en de la lista 
                        if (myList.Count > 0)
                        {
                            Console.WriteLine("Tareas completadas:");
                            foreach (string element in myList)
                            {
                                if (element.StartsWith("[X] "))
                                {
                                    Console.WriteLine(element.Substring(3));
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("La lista está vacía");
                        }
                        break;
                    case 5:
                        // Marcar y desmarcar tarea las cuales estan completas 
                        if (myList.Count > 0)
                        {
                            Console.Write("Ingrese el nombre de la tarea a marcar o desmarcar: ");
                            string taskToMark = Console.ReadLine();
                            int index = myList.IndexOf(taskToMark);
                            if (index >= 0)
                            {
                                string currentTask = myList[index];
                                myList[index] = currentTask.StartsWith("[X] ") ? currentTask.Substring(3) : "[X] " + currentTask;
                                Console.WriteLine("Tarea marcada/desmarcada correctamente");
                            }
                            else
                            {
                                Console.WriteLine("La tarea no existe en la lista");
                            }
                        }
                        else
                        {
                            Console.WriteLine("La lista está vacía");
                        }
                        break;
                    case 6:
                        // Salir del programa
                        return;
                }
            }
        }
    }
}