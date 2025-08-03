using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO2.Ejercicio4
{
    public abstract class DispositivoSalida
    {
        public abstract void MostrarMensaje(string mensaje);
    }

    public class Pantalla : DispositivoSalida
    {
        public override void MostrarMensaje(string mensaje)
        {
            Console.WriteLine($"{mensaje}");
        }
    }

    public class Proyector : DispositivoSalida
    {
        public override void MostrarMensaje(string mensaje)
        {
            Console.WriteLine($"Lanzando proyección: {mensaje}");
        }
    }

    public class Impresora : DispositivoSalida
    {
        public override void MostrarMensaje(string mensaje)
        {
            Console.WriteLine($"Imprimiendo mensaje {mensaje}");
        }
    }
}
