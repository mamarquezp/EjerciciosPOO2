using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO2.Ejercicio3
{
    public class Ejercicio3
    {
        public static void Ejecutar()
        {
            /*Notificacion email = new NotificacionEmail();
            Notificacion sms = new NotificacionSMS();
            Notificacion push = new NotificacionPush();
            email.Enviar("Hola, este es una prueba de email");
            sms.Enviar("Hola, esta es una prueba de mensaje de texto");
            push.Enviar("Hola, esta es una prueba de mensaje push");*/

            List<Notificacion> notificaciones = new List<Notificacion>
            {
                new NotificacionEmail(),
                new NotificacionSMS(),
                new NotificacionPush()
            };

            foreach (var notificacion in notificaciones)
            {
                notificacion.Enviar("Hola, esta es una prueba");
            }

            EjecutaComandos ejecutaComandos = new EjecutaComandos();
            ejecutaComandos.AgregarComando(new EncenderLuces());
            ejecutaComandos.AgregarComando(new ReproducirMusica());
            ejecutaComandos.AgregarComando(new MostrarClima());


            ejecutaComandos.EjecutarComandos();

            List<Pago> pagos = new List<Pago>
            {
                new PagoConTarjeta(),
                new PagoConEfectivo(),
                new PagoConTransferencia()
            };

            foreach (var pago in pagos)
            {
                pago.ProcesarPago();
            }
        }
    }
}
