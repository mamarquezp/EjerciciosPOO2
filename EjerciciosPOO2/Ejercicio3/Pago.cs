using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO2.Ejercicio3
{
    public class Pago
    {
        public virtual void ProcesarPago()
        {
            Console.WriteLine("Procesando pago...");
        }       
    }
    
    public class PagoConTarjeta : Pago
    {
        public override void ProcesarPago()
        {
            Console.WriteLine("Procesando pago con tarjeta...");
        }
    }
    public class PagoConEfectivo : Pago
    {
        public override void ProcesarPago()
        {
            Console.WriteLine("Procesando pago con efectivo...");
        }
    }
    public class PagoConTransferencia : Pago
    {
        public override void ProcesarPago()
        {
            Console.WriteLine("Procesando pago con transferencia bancaria...");
        }
    }
}
