using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO2.Ejercicio4
{
    public abstract class ArchivoMultimedia
    {
        public abstract void Reproducir();
    }

    public class Video : ArchivoMultimedia
    {
        public override void Reproducir()
        {
            Console.WriteLine("Reproduciendo video...");
        }
    }

    public class Cancion : ArchivoMultimedia
    {
        public override void Reproducir()
        {
            Console.WriteLine("Reproduciendo canción...");
        }
    }

    public class AudioLibro : ArchivoMultimedia
    {
        public override void Reproducir()
        {
            Console.WriteLine("Narrando audiolibro...");
        }
    }
}
