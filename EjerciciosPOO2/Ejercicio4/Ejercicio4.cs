using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO2.Ejercicio4
{
    public class Ejercicio4
    {
        public static void Ejecutar()
        {
            List<ArchivoMultimedia> misArchivos = new List<ArchivoMultimedia>
        {
            new Video(),
            new Cancion(),
            new AudioLibro()
        };

            foreach (var archivo in misArchivos)
            {
                archivo.Reproducir();
            }

            List<Validador> validadores = new List<Validador>
        {
            new ValidadorEmail(),
            new ValidadorTelefono(),
            new ValidadorDPI()
        };

            string[] datosPrueba = { "test@correo.com", "12345678", "texto-invalido", "1234567890123" };

            foreach (var dato in datosPrueba)
            {
                Console.WriteLine($"Validando el dato: '{dato}'");
                foreach (var validador in validadores)
                {
                    bool esValido = validador.EsValido(dato);
                    Console.WriteLine($"  El {validador.GetType().Name} es {esValido}");
                }
            }

            List<DispositivoSalida> dispositivos = new List<DispositivoSalida>
        {
            new Pantalla(),
            new Proyector(),
            new Impresora()
        };

            foreach (var dispositivo in dispositivos)
            {
                dispositivo.MostrarMensaje("Aprendemos los pilares de la POO");
            }
        }
    }
}
