using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea6.Models
{
    public class Calculadora
    {
        public double number1 { get; set; }
        public double number2 { get; set; }

        public int CalcularSuma()
        {
            int suma = (int)(number1 + number2);
            return suma;
        }

        public int CalcularResta()
        {
            int resta = (int)(number1 - number2);
            return resta;
        }

        public int CalcularMultiplicacion()
        {
            int multiplicar = (int)(number1 * number2);
            return multiplicar;
        }

        public int CalcularDivision()
        {
            int dividir = (int)(number1 / number2);
            return dividir;
        }

        public override string ToString()
        {
            return $"Resultado: {CalcularSuma()}";
        }
    }
}
