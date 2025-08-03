using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO2.Ejercicio3
{
    public class ComandoVoz
    {
        public virtual void Ejecutar()
        { }
    }

    public class EncenderLuces : ComandoVoz
    {
        public override void Ejecutar()
        {
            Console.WriteLine("Se encendieron las luces");
        }
    }

    public class ReproducirMusica : ComandoVoz
    {
        public override void Ejecutar()
        {
            Console.WriteLine("Se inició el reproductor de música");
        }
    }

    public class MostrarClima : ComandoVoz
    {
        public override void Ejecutar()
        {
            Console.WriteLine("Para hoy no se esperan lluvias, la temperatura es de 16° C");
        }
    }

    // funcion que recibe una lista de comandos y los ejecuta
    public class EjecutaComandos
    {
        private List<ComandoVoz> comandos = new List<ComandoVoz>();
        public void AgregarComando(ComandoVoz comando)
        {
            comandos.Add(comando);
        }
        public void EjecutarComandos()
        {
            foreach (var comando in comandos)
            {
                comando.Ejecutar();
            }
        }
    }
}
