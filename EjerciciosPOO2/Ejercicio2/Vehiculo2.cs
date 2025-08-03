using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO2.Ejercicio2
{
    public class Vehiculo2
    {
        public void Avanzar()
        {
            Console.WriteLine("El vehículo está avanzando");
        }
    }
    public class Auto : Vehiculo2
    {
        public void EncenderRadio()
        {
            Console.WriteLine("El auto ha encendido la radio");
        }
    }
    public class Motocicleta : Vehiculo2
    {
        public void HacerCaballito()
        {
            Console.WriteLine("La motocicleta hizo un caballito");
        }
    }

}
