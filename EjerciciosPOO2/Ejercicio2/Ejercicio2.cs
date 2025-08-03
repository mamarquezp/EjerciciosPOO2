using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO2.Ejercicio2
{
    public class Ejercicio2
    {
        public static void Ejecutar()
        {
            Gerente gerente = new Gerente { Nombre = "Claudio Solis", Salario = 15000 };
            Desarrollador dev = new Desarrollador { Nombre = "Daniel Luna", Salario = 9000 };
            Console.WriteLine($"Empleado: {gerente.Nombre}, Salario: Q{gerente.Salario}");
            gerente.TomarDecision();
            Console.WriteLine($"Empleado: {dev.Nombre}, Salario: Q{dev.Salario}");
            dev.Programar();

            Auto miAuto = new Auto();
            miAuto.Avanzar();
            miAuto.EncenderRadio();
            Motocicleta miMoto = new Motocicleta();
            miMoto.Avanzar();
            miMoto.HacerCaballito();

            List<CuentaBancaria2> cuentas = new List<CuentaBancaria2>();
            var cuentaAhorro = new CuentaAhorro { Propietario = "Ana" };
            cuentaAhorro.Depositar(2000);
            cuentaAhorro.MostrarSaldo();
            cuentaAhorro.CalcularIntereses();
            cuentaAhorro.MostrarSaldo();

            var cuentaCorriente = new CuentaCorriente { Propietario = "Pedro" };
            cuentaCorriente.Depositar(2000);
            cuentaCorriente.MostrarSaldo();
            cuentaCorriente.CalcularIntereses();
            cuentaCorriente.MostrarSaldo();
        }
    }
}