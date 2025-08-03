using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO2.Ejercicio1
{
    public class CuentaBancaria
    {
        private string propietario ="";
        private double saldo;
        public double limiteRetiro;

        public required string Propietario { get; set; }
        public void MostrarSaldo()
        {
            Console.WriteLine($"El saldo actual de la cuenta de {propietario} es: Q{saldo}");
        }
        //limite de retiro diario
        public void Retirar(double cantidad)
        {
            if (cantidad <= saldo)
            {
                if (cantidad > limiteRetiro)
                {
                    Console.WriteLine($"No se puede retirar más de Q{limiteRetiro} al día.");
                    return;
                }
                saldo -= cantidad;
                limiteRetiro -= cantidad;
                Console.WriteLine($"Se han retirado Q{cantidad}.");
            }
            else
            {
                Console.WriteLine("Fondos insuficientes para realizar el retiro.");
            }
        }

    }
}
