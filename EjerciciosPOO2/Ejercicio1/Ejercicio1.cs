using EjerciciosPOO2.Ejercicio2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO2.Ejercicio1
{
    public class Ejercicio1
    {
        public static void Ejecutar()
        {
            Empleado empleado1 = new Empleado();
            empleado1.Nombre = "Pedro Hernandez";
            empleado1.Salario = 5000;
            Console.WriteLine($"Empleado: {empleado1.Nombre}, Salario: Q{empleado1.Salario}");

            empleado1.Salario = -100; // salario negativo


            CuentaBancaria miCuenta = new CuentaBancaria("Ana López", 2500, 1000);
            miCuenta.MostrarSaldo();
            miCuenta.Retirar(500); // Válido
            miCuenta.MostrarSaldo();

            miCuenta.Retirar(600); // Inválido
            miCuenta.MostrarSaldo();

            miCuenta.Retirar(3000); // Inválido
            miCuenta.MostrarSaldo();


            Vehiculo miAuto = new Vehiculo();
            Console.WriteLine($"¿El vehículo está encendido? {miAuto.encendido}");

            miAuto.Encender();
            Console.WriteLine($"¿El vehículo está encendido? {miAuto.encendido}");

            miAuto.Apagar();
            Console.WriteLine($"¿El vehículo está encendido? {miAuto.encendido}");
        }
    }
}
