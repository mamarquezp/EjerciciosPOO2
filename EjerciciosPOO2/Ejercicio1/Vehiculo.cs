using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO2.Ejercicio1
{
    public class Vehiculo
    {
        public bool encendido { get; private set; }
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
