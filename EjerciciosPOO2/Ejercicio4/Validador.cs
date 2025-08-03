using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO2.Ejercicio4
{
    public interface Validador
    {
        bool EsValido(string dato);
    }

    public class ValidadorEmail : Validador
    {
        public bool EsValido(string dato)
        {
            return !string.IsNullOrWhiteSpace(dato) && dato.Contains("@") && dato.Contains(".");
        }
    }

    public class ValidadorTelefono : Validador
    {
        public bool EsValido(string dato)
        {
            return !string.IsNullOrWhiteSpace(dato) && dato.All(char.IsDigit) && dato.Length == 8;
        }
    }

    public class ValidadorDPI : Validador
    {
        public bool EsValido(string dato)
        {
            return !string.IsNullOrWhiteSpace(dato) && dato.All(char.IsDigit) && dato.Length == 13;
        }
    }
}
