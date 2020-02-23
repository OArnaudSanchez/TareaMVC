using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTareaa.Formulas
{
    public class Masa
    {

        private double Resultado;

        public double ConversionMasa(string opcion)
        {

            Resultado = 0;

            if (opcion== "Gramo/Kilogramo")
            {

            }
            else if (opcion == "Gramo/Onza ")
            {

            }
            else if (opcion == "Gramo/Libra")
            {

            }


            else if (opcion == "Kilogramo/Gramo")
            {

            }
            else if (opcion == "Kilogramo/Onza ")
            {

            }
            else if (opcion == "Kilogramo/Libra")
            {

            }


            else if (opcion == "Onza/Gramo")
            {

            }
            else if (opcion == "Onza/Kilogramo ")
            {

            }
            else if (opcion == "Onza/Libra")
            {

            }


            else if (opcion == "Libra/Gramo")
            {

            }
            else if (opcion == "Libra/Kilogramo ")
            {

            }
            else if (opcion == "Libra/Onza")
            {

            }

            return Resultado;
        }
    }
}