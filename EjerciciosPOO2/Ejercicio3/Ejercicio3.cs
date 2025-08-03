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
            Notificacion email = new NotificacionEmail();
            Notificacion sms = new NotificacionSMS();
            Notificacion push = new NotificacionPush();
            email.Enviar("Hola, este es una prueba de email");
            sms.Enviar("Hola, esta es una prueba de mensaje de texto");
            push.Enviar("Hola, esta es una prueba de mensaje push");

            ComandoVoz encenderLuces = new EncenderLuces();
            ComandoVoz reproducirMusica = new ReproducirMusica();
            ComandoVoz mostrarClima = new MostrarClima();

            EjecutaComandos ejecutaComandos = new EjecutaComandos();
            ejecutaComandos.AgregarComando(encenderLuces);
            ejecutaComandos.AgregarComando(reproducirMusica);
            ejecutaComandos.AgregarComando(mostrarClima);

            //Simula una caja registradora que recorra una lista de objetos Pago y procese cada uno.
            
        List<Pago> pagos = new List<Pago>
            {
                new PagoTarjetaCredito(),
                new PagoEfectivo(),
                new PagoTransferencia()
            }
        }
    }
}
