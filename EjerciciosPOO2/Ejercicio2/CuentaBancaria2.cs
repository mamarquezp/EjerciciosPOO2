using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO2.Ejercicio2
{
    public class CuentaBancaria2
    {
        private string propietario ="";
        protected double saldo; // Cambiado de private a protected
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
        public void Depositar(double cantidad)
        {
            if (cantidad > 0)
            {
                saldo += cantidad;
                Console.WriteLine($"Se han depositado Q{cantidad}.");
            }
            else
            {
                Console.WriteLine("La cantidad a depositar debe ser mayor que cero.");
            }
        }
    }

        
        public class CuentaAhorro : CuentaBancaria2
        {
            public void CalcularInteres()
            {
            double tasaInteres = 0.07;
            saldo += saldo * tasaInteres;
        }
        }
        public class CuentaCorriente : CuentaBancaria2
        {
            public void CalcularInteres()
            {
                double tasaInteres = 0.03;
                saldo += saldo * tasaInteres;
        }
        }
    }
