using EjerciciosPOO2.Ejercicio1;
using EjerciciosPOO2.Ejercicio2;
using EjerciciosPOO2.Ejercicio3;
using EjerciciosPOO2.Ejercicio4;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        // menu de opciones
        Console.WriteLine("Ejercicio 1: Encapsulación");       
        Console.WriteLine("Ejercicio 2: Herencia");   
        Console.WriteLine("Ejercicio 3: Polimorfismo");
        Console.WriteLine("Ejercicio 4: Abstracción");

        Console.WriteLine("Seleccione el ejercicio que desea ejecutar");
        string opcion = Console.ReadLine();
        switch (opcion)
        {
            case "1":
                Ejercicio1.Ejecutar();
                break;
            case "2":
                Ejercicio2.Ejecutar();
                break;
            case "3":
                Ejercicio3.Ejecutar();
                break;
            case "4":
                Ejercicio4.Ejecutar();
                break;
            default:
                Console.WriteLine("Opción no válida. Saliendo del programa.");
                return;
        }



        

        

        




    }


}
