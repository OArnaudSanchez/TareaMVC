using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTareaa.Formulas
{
    public class Temperatura
    {
        private double Resultado;

        public double ConversionTemperaturas(string opcion)
        {
            Resultado = 0;

            if (opcion == "Celcius/Farenheit")
            {

            }
            else if (opcion == "Celcius/Kelvin")
            {

            }


            else if (opcion == "Farenheit/Celcius")
            {

            }
            else if (opcion == "Farenheit/kelvin")
            {

            }


            else if (opcion == "Kelvin/Celcius")
            {

            }
            else if (opcion == "Kelvin/Farenheit")
            {

            }
            return Resultado;
        }
    }
}