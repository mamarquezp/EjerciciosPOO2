using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO2.Ejercicio3
{
    public class Notificacion
    {
        public virtual void Enviar(string mensaje)
        {
            Console.WriteLine($"Enviando notificación: {mensaje}");
        }
    }

    public class NotificacionEmail : Notificacion
    {
        public override void Enviar(string mensaje)
        {
            Console.WriteLine($"Enviando correo electrónico: {mensaje}");
        }
    }

    public class NotificacionSMS : Notificacion
    {
        public override void Enviar(string mensaje)
        {
            Console.WriteLine($"Enviando SMS: {mensaje}");
        }
    }

    public class NotificacionPush : Notificacion
    {
        public override void Enviar(string mensaje)
        {
            Console.WriteLine($"Enviando notificación Push: {mensaje}");
        }
    }
}
