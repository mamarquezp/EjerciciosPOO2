using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO2.Ejercicio1
{
    public class Vehículo
    {
        private Boolean encendido;
        public void Encender()
        {
            Console.WriteLine("El vehículo ha sido encendido.");
            encendido = true;
        }
        public void Apagar()
        {
            Console.WriteLine("El vehículo ha sido apagado.");
            encendido = false;
        }
    }
}
