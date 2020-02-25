using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCTareaa.Models
{
    public class DatosConversiones
    {
        [Required(ErrorMessage = "Debe ingresar el valor para convertir")]
        public double CampoTexto { get; set; }
        public string  OpcionConversion { get; set; }
        private double Resultado { get; set; }

        public ConvesionesTemperaturasFormaCorta1 ConvesionesTemperaturasFormaCorta1 { get; set; }
        public ConvesionesTemperaturasFormaCorta2 ConvesionesTemperaturasFormaCorta2 { get; set; }

        public ConvesionesMasaFormaCorta1 ConvesionesMasaFormaCorta1 { get; set; }
        public ConvesionesMasaFormaCorta2 ConvesionesMasaFormaCorta2 { get; set; }

        public ConvesionesLongitudFormaCorta1 ConvesionesLongitudFormaCorta1 { get; set; }
        public ConvesionesLongitudFormaCorta2 ConvesionesLongitudFormaCorta2 { get; set; }

        public ConvesionesDatosFormaCorta1 ConvesionesDatosFormaCorta1 { get; set; }
        public ConvesionesDatosFormaCorta2 ConvesionesDatosFormaCorta2 { get; set; }



        public string ConversionTemperaturaFormaCorta()
        {
            if (ConvesionesTemperaturasFormaCorta1.ToString() == "Celcius" && ConvesionesTemperaturasFormaCorta2.ToString()== "Farenheit")
            {
                Resultado = (CampoTexto * 1.8) + 32;
            }
            else if (ConvesionesTemperaturasFormaCorta1.ToString() == "Celcius" && ConvesionesTemperaturasFormaCorta2.ToString() == "Kelvin")
            {
                Resultado = 273 + CampoTexto;
            }

            else if (ConvesionesTemperaturasFormaCorta1.ToString() == "Farenheit" && ConvesionesTemperaturasFormaCorta2.ToString() == "Celcius")
            {
                Resultado = ((CampoTexto - 32) / 1.8);
            }
            else if (ConvesionesTemperaturasFormaCorta1.ToString() == "Farenheit" && ConvesionesTemperaturasFormaCorta2.ToString() == "Kelvin")
            {
                Resultado = ((CampoTexto - 32) / 1.8000) + 273.15;
            }

            else if (ConvesionesTemperaturasFormaCorta1.ToString() == "Kelvin" && ConvesionesTemperaturasFormaCorta2.ToString() == "Celcius")
            {
                Resultado = CampoTexto - 273;
            }
            else if (ConvesionesTemperaturasFormaCorta1.ToString() == "Kelvin" && ConvesionesTemperaturasFormaCorta2.ToString() == "Farenheit")
            {
                Resultado = ((CampoTexto - 273.15) * 1.8000) + 32.00;
            }
            else
            {
                Resultado = 0;   
            }
            return "El Resultado De Convertir " + CampoTexto + " " + ConvesionesTemperaturasFormaCorta1.ToString() +" A "
                +ConvesionesTemperaturasFormaCorta2.ToString() + " Es: "+ Resultado + " Grados " +ConvesionesTemperaturasFormaCorta2.ToString();

        }

        public string ConversionLongitudFormaCorta()
        {
            if (ConvesionesLongitudFormaCorta1.ToString() == "Centimetro" && ConvesionesLongitudFormaCorta2.ToString()=="Pies")
            {
                Resultado = Math.Round((CampoTexto / 30.48), 10);
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Centimetro" && ConvesionesLongitudFormaCorta2.ToString() == "Pulgadas")
            {
                Resultado = Math.Round((CampoTexto / 2.54), 10);
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Centimetro" && ConvesionesLongitudFormaCorta2.ToString() == "Metros")
            {
                Resultado = Math.Round((CampoTexto / 100), 10);
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Centimetro" && ConvesionesLongitudFormaCorta2.ToString() == "Kilometros")
            {
                Resultado = Math.Round((CampoTexto / 100000), 10);
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Centimetro" && ConvesionesLongitudFormaCorta2.ToString() == "Millas")
            {
                Resultado = Math.Round((CampoTexto / 160934), 10);//La conversion es un resultado aproximado
            }

            else if (ConvesionesLongitudFormaCorta1.ToString() == "Pies" && ConvesionesLongitudFormaCorta2.ToString() == "Centimetro")
            {
                Resultado = CampoTexto * 30.48;
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Pies" && ConvesionesLongitudFormaCorta2.ToString() == "Pulgadas")
            {
                Resultado = CampoTexto * 12;
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Pies" && ConvesionesLongitudFormaCorta2.ToString() == "Metros")
            {
                Resultado = CampoTexto / 3.281;//Valor Aproximado
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Pies" && ConvesionesLongitudFormaCorta2.ToString() == "Kilometros")
            {
                Resultado = CampoTexto / 3281;//Valor Aproximado
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Pies" && ConvesionesLongitudFormaCorta2.ToString() == "Millas")
            {
                Resultado = CampoTexto / 5280;
            }

            else if (ConvesionesLongitudFormaCorta1.ToString() == "Pulgadas" && ConvesionesLongitudFormaCorta2.ToString() == "Centimetro")
            {
                Resultado = CampoTexto * 2.54;
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Pulgadas" && ConvesionesLongitudFormaCorta2.ToString() == "Pies")
            {
                Resultado = CampoTexto / 12;
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Pulgadas" && ConvesionesLongitudFormaCorta2.ToString() == "Metros")
            {
                Resultado = CampoTexto / 39.37;
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Pulgadas" && ConvesionesLongitudFormaCorta2.ToString() == "Kilometros")
            {
                Resultado = CampoTexto / 39370;//Valor Aprox
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Pulgadas" && ConvesionesLongitudFormaCorta2.ToString() == "Milla")
            {
                Resultado = CampoTexto / 63360;
            }

            else if (ConvesionesLongitudFormaCorta1.ToString() == "Metros" && ConvesionesLongitudFormaCorta2.ToString() == "Centimetros")
            {
                Resultado = CampoTexto / 100;
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Metros" && ConvesionesLongitudFormaCorta2.ToString() == "Pies")
            {
                Resultado = CampoTexto * 3.281;//Valor Aprox
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Metros" && ConvesionesLongitudFormaCorta2.ToString() == "Pulgadas")
            {
                Resultado = CampoTexto * 39.37;
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Metros" && ConvesionesLongitudFormaCorta2.ToString() == "Kilometros")
            {
                Resultado = CampoTexto / 1000;
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Metros" && ConvesionesLongitudFormaCorta2.ToString() == "Millas")
            {
                Resultado = CampoTexto / 1609;//Valor Aprox
            }

            else if (ConvesionesLongitudFormaCorta1.ToString() == "Kilometros" && ConvesionesLongitudFormaCorta2.ToString() == "Centimetro")
            {
                Resultado = CampoTexto * 100000;
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Kilometros" && ConvesionesLongitudFormaCorta2.ToString() == "Pies")
            {
                Resultado = CampoTexto * 3281;//Valor aprox
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Kilometros" && ConvesionesLongitudFormaCorta2.ToString() == "Pulgadas")
            {
                Resultado = CampoTexto * 39370;//Valor Aprox
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Kilometros" && ConvesionesLongitudFormaCorta2.ToString() == "Metros")
            {
                Resultado = CampoTexto * 1000;
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Kilometros" && ConvesionesLongitudFormaCorta2.ToString() == "Millas")
            {
                Resultado = CampoTexto * 0.62137;
            }

            else if (ConvesionesLongitudFormaCorta1.ToString() == "Millas" && ConvesionesLongitudFormaCorta2.ToString() == "Centimetro")
            {
                Resultado = CampoTexto * 160934;//Valor aprox 
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Millas" && ConvesionesLongitudFormaCorta2.ToString() == "Pies")
            {
                Resultado = CampoTexto * 5280;
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Millas" && ConvesionesLongitudFormaCorta2.ToString() == "Pulgadas")
            {
                Resultado = CampoTexto * 63360;
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Millas" && ConvesionesLongitudFormaCorta2.ToString() == "Metros")
            {
                Resultado = CampoTexto * 1609;//Valor Aproximado
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Millas" && ConvesionesLongitudFormaCorta2.ToString() == "Kilometros")
            {
                Resultado = CampoTexto * 1.609;
            }
            else
            {
                Resultado = 0.00;
            }

            return "El Resultado De Convertir " + CampoTexto + " " + ConvesionesLongitudFormaCorta1.ToString() + " A " +
                ConvesionesLongitudFormaCorta2.ToString() + " Es: " + Resultado + " " + ConvesionesLongitudFormaCorta2.ToString();
        }

        public string ConversionMasaFormaCorta()
        {
            if (ConvesionesMasaFormaCorta1.ToString() == "Gramo" && ConvesionesMasaFormaCorta2.ToString() == "Kilogramo")
            {
                Resultado = CampoTexto / 1000;
            }
            else if (ConvesionesMasaFormaCorta1.ToString() == "Gramo" && ConvesionesMasaFormaCorta2.ToString() == "Onza")
            {
                Resultado = CampoTexto / 28.35;//Valor Aprox
            }
            else if (ConvesionesMasaFormaCorta1.ToString() == "Gramo" && ConvesionesMasaFormaCorta2.ToString() == "Libra")
            {
                Resultado = CampoTexto / 454;//Valor Aprox
            }


            else if (ConvesionesMasaFormaCorta1.ToString() == "Kilogramo" && ConvesionesMasaFormaCorta2.ToString() == "Gramo")
            {
                Resultado = Math.Round((CampoTexto * 1000), 10);
            }
            else if (ConvesionesMasaFormaCorta1.ToString() == "Kilogramo" && ConvesionesMasaFormaCorta2.ToString() == "Onza")
            {
                Resultado = CampoTexto * 35.274;
            }
            else if (ConvesionesMasaFormaCorta1.ToString() == "Kilogramo" && ConvesionesMasaFormaCorta2.ToString() == "Libra")
            {
                Resultado = CampoTexto * 2.205;//Valor Aprox
            }


            else if (ConvesionesMasaFormaCorta1.ToString() == "Onza" && ConvesionesMasaFormaCorta2.ToString() == "Gramo")
            {
                Resultado = CampoTexto * 28.35;//Valor Aprox
            }
            else if (ConvesionesMasaFormaCorta1.ToString() == "Onza" && ConvesionesMasaFormaCorta2.ToString() == "Kilogramo")
            {
                Resultado = CampoTexto / 35.274;
            }
            else if (ConvesionesMasaFormaCorta1.ToString() == "Onza" && ConvesionesMasaFormaCorta2.ToString() == "Libra")
            {
                Resultado = CampoTexto / 16;
            }

            else if (ConvesionesMasaFormaCorta1.ToString() == "Libra" && ConvesionesMasaFormaCorta2.ToString() == "Gramo")
            {
                Resultado = CampoTexto / 454;//Valor Aprox

            }
            
            else if (ConvesionesMasaFormaCorta1.ToString() == "Libra" && ConvesionesMasaFormaCorta2.ToString() == "Kilogramo")
            {
                Resultado = CampoTexto / 2.205;//Valor Aprox
            }
            else if (ConvesionesMasaFormaCorta1.ToString() == "Libra" && ConvesionesMasaFormaCorta2.ToString() == "Onza")
            {
                Resultado = CampoTexto * 16;
            }
            else
            {
                Resultado = 0.00;
            }
            return "El Resultado De Convertir " + CampoTexto + " " + ConvesionesMasaFormaCorta1.ToString() + " A " +
                ConvesionesMasaFormaCorta2.ToString() + " Es: " + Resultado + " " + ConvesionesMasaFormaCorta2.ToString();
        }

        public string ConversionDatosFormaCorta()
        {

            if (ConvesionesDatosFormaCorta1.ToString() == "Bit" && ConvesionesDatosFormaCorta2.ToString()=="Byte")
            {
                Resultado = Math.Round((CampoTexto / 8), 10);
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Bit" && ConvesionesDatosFormaCorta2.ToString() == "Kilobyte")
            {
                Resultado = CampoTexto / 8000;
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Bit" && ConvesionesDatosFormaCorta2.ToString() == "Megabyte")
            {
                Resultado = CampoTexto / 8e+6;
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Bit" && ConvesionesDatosFormaCorta2.ToString() == "Gigabyte")
            {
                Resultado = CampoTexto / 8e+9;
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Bit" && ConvesionesDatosFormaCorta2.ToString() == "Terabyte")
            {
                Resultado = CampoTexto / 8e+12;
            }

            else if (ConvesionesDatosFormaCorta1.ToString() == "Byte" && ConvesionesDatosFormaCorta2.ToString() == "Bit")
            {
                Resultado = CampoTexto * 8;
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Byte" && ConvesionesDatosFormaCorta2.ToString() == "Kilobyte")
            {
                Resultado = CampoTexto / 1000;
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Byte" && ConvesionesDatosFormaCorta2.ToString() == "Megabyte")
            {
                Resultado = CampoTexto / 1e+6;
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Bit" && ConvesionesDatosFormaCorta2.ToString() == "Gigabyte")
            {
                Resultado = CampoTexto / 1e+9;
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Bit" && ConvesionesDatosFormaCorta2.ToString() == "Terabyte")
            {
                Resultado = CampoTexto / 1e+12;
            }

            else if (ConvesionesDatosFormaCorta1.ToString() == "Kilobyte" && ConvesionesDatosFormaCorta2.ToString() == "Bit")
            {
                Resultado = CampoTexto * 8000;
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Kilobyte" && ConvesionesDatosFormaCorta2.ToString() == "Byte")
            {
                Resultado = CampoTexto * 1000;
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Kilobyte" && ConvesionesDatosFormaCorta2.ToString() == "Megabyte")
            {
                Resultado = CampoTexto / 1000;
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Kilobyte" && ConvesionesDatosFormaCorta2.ToString() == "Gigabyte")
            {
                Resultado = CampoTexto / 1e+6;
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Kilobyte" && ConvesionesDatosFormaCorta2.ToString() == "Terabyte")
            {
                Resultado = CampoTexto / 1e+9; //Valor Aprox
            }

            else if (ConvesionesDatosFormaCorta1.ToString() == "Megabyte" && ConvesionesDatosFormaCorta2.ToString() == "Bit")
            {
                Resultado = CampoTexto * 8e+6;
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Megabyte" && ConvesionesDatosFormaCorta2.ToString() == "Byte")
            {
                Resultado = CampoTexto * 1e+6;
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Megabyte" && ConvesionesDatosFormaCorta2.ToString() == "Kilobyte")
            {
                Resultado = CampoTexto * 1000;
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Megabyte" && ConvesionesDatosFormaCorta2.ToString() == "Gigabyte")
            {
                Resultado = CampoTexto / 1000;
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Megabyte" && ConvesionesDatosFormaCorta2.ToString() == "Terabyte")
            {
                Resultado = CampoTexto / 1e+6;
            }

            else if (ConvesionesDatosFormaCorta1.ToString() == "Gigabyte" && ConvesionesDatosFormaCorta2.ToString() == "Bit")
            {
                Resultado = CampoTexto * 8e+9;
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Gigabyte" && ConvesionesDatosFormaCorta2.ToString() == "Byte")
            {
                Resultado = CampoTexto * 1e+9;
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Gigabyte" && ConvesionesDatosFormaCorta2.ToString() == "Kilobyte")
            {
                Resultado = CampoTexto * 1e+6;
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Gigabyte" && ConvesionesDatosFormaCorta2.ToString() == "Megabyte")
            {
                Resultado = CampoTexto * 1000;
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Gigabyte" && ConvesionesDatosFormaCorta2.ToString() == "Terabyte")
            {
                Resultado = CampoTexto / 1000;
            }

            else if (ConvesionesDatosFormaCorta1.ToString() == "Terabyte" && ConvesionesDatosFormaCorta2.ToString() == "Bit")
            {
                Resultado = CampoTexto * 8e+12;
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Terabyte" && ConvesionesDatosFormaCorta2.ToString() == "Byte")
            {
                Resultado = CampoTexto * 1e+12;
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Terabyte" && ConvesionesDatosFormaCorta2.ToString() == "Kilobyte")
            {
                Resultado = CampoTexto * 1e+9;
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Terabyte" && ConvesionesDatosFormaCorta2.ToString() == "Megabyte")
            {
                Resultado = CampoTexto * 1e+6;
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Terabyte" && ConvesionesDatosFormaCorta2.ToString() == "Gigabyte")
            {
                Resultado = CampoTexto * 1000;
            }


            return "El Resultado De Convertir " + CampoTexto + " " + ConvesionesDatosFormaCorta1.ToString() + " A " +
                ConvesionesDatosFormaCorta2.ToString() + " Es: " + Resultado + " " + ConvesionesDatosFormaCorta2.ToString();
        }
    }

   public enum ConvesionesTemperaturasFormaCorta1
    {
        Celcius, Kelvin, Farenheit
    }
    public enum ConvesionesTemperaturasFormaCorta2
    {
        Celcius, Kelvin, Farenheit
    }


    public enum ConvesionesMasaFormaCorta1
    {
        Gramo , Kilogramo,Onza,Libra
    }

    public enum ConvesionesMasaFormaCorta2
    {
        Gramo, Kilogramo, Onza, Libra
    }


    public enum ConvesionesLongitudFormaCorta1
    {
        Centimetro, Pies, Pulgadas,Metros ,Kilometros,Millas
    }
    public enum ConvesionesLongitudFormaCorta2
    {
        Centimetro, Pies, Pulgadas, Metros, Kilometros, Millas
    }


    public enum ConvesionesDatosFormaCorta1
    {
        Bit, Byte, Kilobyte, Megabyte, Gigabyte, Terabyte
    }
    public enum ConvesionesDatosFormaCorta2
    {
        Bit, Byte, Kilobyte, Megabyte, Gigabyte, Terabyte
    }
}