using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO2.Ejercicio2
{
    public class Empleado2
    {
        private string nombre ="";
        private double salario;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    nombre = value;
                }
            }
        }
        public double Salario
        {
            get { return salario; }
            set
            {
                if (value >= 0)
                {
                    salario = value;
                }
            }
        }
        public class Gerente : Empleado2
        {
            public void TomarDecision()
            {
                Console.WriteLine("Se ha tomado una decisión");
            }
        }
        public class Desarrollador : Empleado2
        {
            public void Programar()
            {
                Console.WriteLine("Escribiendo código");
            }
        }
    }
}
