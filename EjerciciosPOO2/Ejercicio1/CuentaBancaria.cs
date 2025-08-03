using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO2.Ejercicio1
{
    public class CuentaBancaria
    {
        public string propietario { get; private set; }
        private double saldo;
        private double limiteRetiroDiario;
        private double retiradoHoy;


        public CuentaBancaria(string propietario, double saldoInicial, double limiteDiario)
        {
            this.propietario = propietario;
            this.saldo = saldoInicial;
            this.limiteRetiroDiario = limiteDiario;
            this.retiradoHoy = 0;
        }
        public void MostrarSaldo()
        {
            Console.WriteLine($"El saldo actual de la cuenta de {propietario} es: Q{saldo}");
        }
        //limite de retiro diario
        public void Retirar(double cantidad)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad a retirar debe ser mayor que 0");
                return;
            }
            if (cantidad > saldo)
            {
                Console.WriteLine("Fondos insuficientes.");
                return;
            }
            if (retiradoHoy + cantidad > limiteRetiroDiario)
            {
                Console.WriteLine($"Límite de retiro diario excedido");
                return;
            }

            saldo -= cantidad;
            retiradoHoy += cantidad;
            Console.WriteLine($"Retiro de Q{cantidad} exitoso");
        }

    }
}
