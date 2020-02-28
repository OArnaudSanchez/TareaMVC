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
                Resultado = Math.Round(((CampoTexto * 1.8) + 32),4);
            }
            else if (ConvesionesTemperaturasFormaCorta1.ToString() == "Celcius" && ConvesionesTemperaturasFormaCorta2.ToString() == "Kelvin")
            {
                Resultado = Math.Round((273 + CampoTexto),4);
            }

            else if (ConvesionesTemperaturasFormaCorta1.ToString() == "Farenheit" && ConvesionesTemperaturasFormaCorta2.ToString() == "Celcius")
            {
                Resultado = Math.Round(((CampoTexto - 32) / 1.8),4);
            }
            else if (ConvesionesTemperaturasFormaCorta1.ToString() == "Farenheit" && ConvesionesTemperaturasFormaCorta2.ToString() == "Kelvin")
            {
                Resultado = Math.Round((((CampoTexto - 32) / 1.8000) + 273.15),4);
            }

            else if (ConvesionesTemperaturasFormaCorta1.ToString() == "Kelvin" && ConvesionesTemperaturasFormaCorta2.ToString() == "Celcius")
            {
                Resultado = Math.Round((CampoTexto - 273),4);
            }
            else if (ConvesionesTemperaturasFormaCorta1.ToString() == "Kelvin" && ConvesionesTemperaturasFormaCorta2.ToString() == "Farenheit")
            {
                Resultado = Math.Round((((CampoTexto - 273.15) * 1.8000) + 32.00),4);
            }
            else
            {
                Resultado = 0000;   
            }
            return "El Resultado De Convertir " + CampoTexto + " " + ConvesionesTemperaturasFormaCorta1.ToString() +" A "
                +ConvesionesTemperaturasFormaCorta2.ToString() + " Es: "+ Resultado + " Grados " +ConvesionesTemperaturasFormaCorta2.ToString();

        }

        public string ConversionLongitudFormaCorta()
        {
            if (ConvesionesLongitudFormaCorta1.ToString() == "Centimetros" && ConvesionesLongitudFormaCorta2.ToString()=="Pies")
            {
                Resultado = Math.Round((CampoTexto / 30.48), 4);
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Centimetros" && ConvesionesLongitudFormaCorta2.ToString() == "Pulgadas")
            {
                Resultado = Math.Round((CampoTexto / 2.54), 4);
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Centimetros" && ConvesionesLongitudFormaCorta2.ToString() == "Metros")
            {
                Resultado = Math.Round((CampoTexto / 100), 4);
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Centimetros" && ConvesionesLongitudFormaCorta2.ToString() == "Kilometros")
            {
                Resultado = Math.Round((CampoTexto / 100000), 4);
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Centimetros" && ConvesionesLongitudFormaCorta2.ToString() == "Millas")
            {
                Resultado = Math.Round((CampoTexto / 160934), 4);//La conversion es un resultado aproximado
            }

            else if (ConvesionesLongitudFormaCorta1.ToString() == "Pies" && ConvesionesLongitudFormaCorta2.ToString() == "Centimetros")
            {
                Resultado = Math.Round((CampoTexto * 30.48),4);
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Pies" && ConvesionesLongitudFormaCorta2.ToString() == "Pulgadas")
            {
                Resultado = Math.Round((CampoTexto * 12),4);
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Pies" && ConvesionesLongitudFormaCorta2.ToString() == "Metros")
            {
                Resultado = Math.Round((CampoTexto / 3.281), 4);//Valor Aproximado
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Pies" && ConvesionesLongitudFormaCorta2.ToString() == "Kilometros")
            {
                Resultado = Math.Round((CampoTexto / 3281),4);//Valor Aproximado
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Pies" && ConvesionesLongitudFormaCorta2.ToString() == "Millas")
            {
                Resultado = Math.Round((CampoTexto / 5280),4);
            }

            else if (ConvesionesLongitudFormaCorta1.ToString() == "Pulgadas" && ConvesionesLongitudFormaCorta2.ToString() == "Centimetros")
            {
                Resultado = Math.Round((CampoTexto * 2.54),4);
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Pulgadas" && ConvesionesLongitudFormaCorta2.ToString() == "Pies")
            {
                Resultado = Math.Round((CampoTexto / 12),4);
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Pulgadas" && ConvesionesLongitudFormaCorta2.ToString() == "Metros")
            {
                Resultado = Math.Round((CampoTexto / 39.37),4);
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Pulgadas" && ConvesionesLongitudFormaCorta2.ToString() == "Kilometros")
            {
                Resultado = Math.Round((CampoTexto / 39370),4);//Valor Aprox
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Pulgadas" && ConvesionesLongitudFormaCorta2.ToString() == "Milla")
            {
                Resultado = Math.Round((CampoTexto / 63360),4);
            }

            else if (ConvesionesLongitudFormaCorta1.ToString() == "Metros" && ConvesionesLongitudFormaCorta2.ToString() == "Centimetros")
            {
                Resultado = Math.Round((CampoTexto * 100),4);
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Metros" && ConvesionesLongitudFormaCorta2.ToString() == "Pies")
            {
                Resultado = Math.Round((CampoTexto * 3.281),4);//Valor Aprox
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Metros" && ConvesionesLongitudFormaCorta2.ToString() == "Pulgadas")
            {
                Resultado =Math.Round(( CampoTexto * 39.37),4);
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Metros" && ConvesionesLongitudFormaCorta2.ToString() == "Kilometros")
            {
                Resultado = Math.Round((CampoTexto / 1000),4);
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Metros" && ConvesionesLongitudFormaCorta2.ToString() == "Millas")
            {
                Resultado = Math.Round((CampoTexto / 1609),4);//Valor Aprox
            }

            else if (ConvesionesLongitudFormaCorta1.ToString() == "Kilometros" && ConvesionesLongitudFormaCorta2.ToString() == "Centimetros")
            {
                Resultado = Math.Round((CampoTexto * 100000),4);
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Kilometros" && ConvesionesLongitudFormaCorta2.ToString() == "Pies")
            {
                Resultado = Math.Round((CampoTexto * 3281),4);//Valor aprox
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Kilometros" && ConvesionesLongitudFormaCorta2.ToString() == "Pulgadas")
            {
                Resultado =Math.Round((CampoTexto * 39370),4);//Valor Aprox
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Kilometros" && ConvesionesLongitudFormaCorta2.ToString() == "Metros")
            {
                Resultado = Math.Round((CampoTexto * 1000),4);
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Kilometros" && ConvesionesLongitudFormaCorta2.ToString() == "Millas")
            {
                Resultado = Math.Round((CampoTexto * 0.62137),4);
            }

            else if (ConvesionesLongitudFormaCorta1.ToString() == "Millas" && ConvesionesLongitudFormaCorta2.ToString() == "Centimetros")
            {
                Resultado = Math.Round((CampoTexto * 160934),4);//Valor aprox 
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Millas" && ConvesionesLongitudFormaCorta2.ToString() == "Pies")
            {
                Resultado = Math.Round((CampoTexto * 5280),4);
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Millas" && ConvesionesLongitudFormaCorta2.ToString() == "Pulgadas")
            {
                Resultado = Math.Round((CampoTexto * 63360),4);
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Millas" && ConvesionesLongitudFormaCorta2.ToString() == "Metros")
            {
                Resultado = Math.Round((CampoTexto * 1609),4);//Valor Aproximado
            }
            else if (ConvesionesLongitudFormaCorta1.ToString() == "Millas" && ConvesionesLongitudFormaCorta2.ToString() == "Kilometros")
            {
                Resultado = Math.Round((CampoTexto * 1.609),4);
            }
            else
            {
                Resultado = 0000;
            }

            return "El Resultado De Convertir " + CampoTexto + " " + ConvesionesLongitudFormaCorta1.ToString() + " A " +
                ConvesionesLongitudFormaCorta2.ToString() + " Es: " + Resultado + " " + ConvesionesLongitudFormaCorta2.ToString();
        }

        public string ConversionMasaFormaCorta()
        {
            if (ConvesionesMasaFormaCorta1.ToString() == "Gramos" && ConvesionesMasaFormaCorta2.ToString() == "Kilogramo")
            {
                Resultado = Math.Round((CampoTexto / 1000),4);
            }
            else if (ConvesionesMasaFormaCorta1.ToString() == "Gramos" && ConvesionesMasaFormaCorta2.ToString() == "Onza")
            {
                Resultado = Math.Round((CampoTexto / 28.35),4);//Valor Aprox
            }
            else if (ConvesionesMasaFormaCorta1.ToString() == "Gramos" && ConvesionesMasaFormaCorta2.ToString() == "Libra")
            {
                Resultado = Math.Round((CampoTexto / 454),4);//Valor Aprox
            }


            else if (ConvesionesMasaFormaCorta1.ToString() == "Kilogramo" && ConvesionesMasaFormaCorta2.ToString() == "Gramos")
            {
                Resultado = Math.Round((CampoTexto * 1000), 4);
            }
            else if (ConvesionesMasaFormaCorta1.ToString() == "Kilogramo" && ConvesionesMasaFormaCorta2.ToString() == "Onza")
            {
                Resultado = Math.Round((CampoTexto * 35.274),4);
            }
            else if (ConvesionesMasaFormaCorta1.ToString() == "Kilogramo" && ConvesionesMasaFormaCorta2.ToString() == "Libra")
            {
                Resultado = Math.Round((CampoTexto * 2.205),4);//Valor Aprox
            }


            else if (ConvesionesMasaFormaCorta1.ToString() == "Onza" && ConvesionesMasaFormaCorta2.ToString() == "Gramos")
            {
                Resultado = Math.Round((CampoTexto * 28.35),4);//Valor Aprox
            }
            else if (ConvesionesMasaFormaCorta1.ToString() == "Onza" && ConvesionesMasaFormaCorta2.ToString() == "Kilogramo")
            {
                Resultado = Math.Round((CampoTexto / 35.274),4);
            }
            else if (ConvesionesMasaFormaCorta1.ToString() == "Onza" && ConvesionesMasaFormaCorta2.ToString() == "Libra")
            {
                Resultado = Math.Round((CampoTexto / 16),4);
            }

            else if (ConvesionesMasaFormaCorta1.ToString() == "Libra" && ConvesionesMasaFormaCorta2.ToString() == "Gramos")
            {
                Resultado = Math.Round((CampoTexto / 454),4);//Valor Aprox

            }
            
            else if (ConvesionesMasaFormaCorta1.ToString() == "Libra" && ConvesionesMasaFormaCorta2.ToString() == "Kilogramo")
            {
                Resultado = Math.Round((CampoTexto / 2.205),4);//Valor Aprox
            }
            else if (ConvesionesMasaFormaCorta1.ToString() == "Libra" && ConvesionesMasaFormaCorta2.ToString() == "Onza")
            {
                Resultado = Math.Round((CampoTexto * 16),4);
            }
            else
            {
                Resultado = 0000;
            }
            return "El Resultado De Convertir " + CampoTexto + " " + ConvesionesMasaFormaCorta1.ToString() + " A " +
                ConvesionesMasaFormaCorta2.ToString() + " Es: " + Resultado + " " + ConvesionesMasaFormaCorta2.ToString();
        }

        public string ConversionDatosFormaCorta()
        {

            if (ConvesionesDatosFormaCorta1.ToString() == "Bit" && ConvesionesDatosFormaCorta2.ToString()=="Byte")
            {
                Resultado = Math.Round((CampoTexto / 8), 4);
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Bit" && ConvesionesDatosFormaCorta2.ToString() == "Kilobyte")
            {
                Resultado = Math.Round((CampoTexto / 8000),4);
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Bit" && ConvesionesDatosFormaCorta2.ToString() == "Megabyte")
            {
                Resultado = Math.Round((CampoTexto / 8e+6),4);
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Bit" && ConvesionesDatosFormaCorta2.ToString() == "Gigabyte")
            {
                Resultado = Math.Round((CampoTexto / 8e+9),4);
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Bit" && ConvesionesDatosFormaCorta2.ToString() == "Terabyte")
            {
                Resultado = Math.Round((CampoTexto / 8e+12),4);
            }

            else if (ConvesionesDatosFormaCorta1.ToString() == "Byte" && ConvesionesDatosFormaCorta2.ToString() == "Bit")
            {
                Resultado = Math.Round((CampoTexto * 8),4);
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Byte" && ConvesionesDatosFormaCorta2.ToString() == "Kilobyte")
            {
                Resultado = Math.Round((CampoTexto / 1000),4);
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Byte" && ConvesionesDatosFormaCorta2.ToString() == "Megabyte")
            {
                Resultado = Math.Round((CampoTexto / 1e+6),4);
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Bit" && ConvesionesDatosFormaCorta2.ToString() == "Gigabyte")
            {
                Resultado = Math.Round((CampoTexto / 1e+9),4);
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Bit" && ConvesionesDatosFormaCorta2.ToString() == "Terabyte")
            {
                Resultado = Math.Round((CampoTexto / 1e+12),4);
            }

            else if (ConvesionesDatosFormaCorta1.ToString() == "Kilobyte" && ConvesionesDatosFormaCorta2.ToString() == "Bit")
            {
                Resultado = Math.Round((CampoTexto * 8000),4);
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Kilobyte" && ConvesionesDatosFormaCorta2.ToString() == "Byte")
            {
                Resultado = Math.Round((CampoTexto * 1000),4);
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Kilobyte" && ConvesionesDatosFormaCorta2.ToString() == "Megabyte")
            {
                Resultado = Math.Round((CampoTexto / 1000),4);
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Kilobyte" && ConvesionesDatosFormaCorta2.ToString() == "Gigabyte")
            {
                Resultado = Math.Round((CampoTexto / 1e+6),4);
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Kilobyte" && ConvesionesDatosFormaCorta2.ToString() == "Terabyte")
            {
                Resultado = Math.Round((CampoTexto / 1e+9),4); //Valor Aprox
            }

            else if (ConvesionesDatosFormaCorta1.ToString() == "Megabyte" && ConvesionesDatosFormaCorta2.ToString() == "Bit")
            {
                Resultado = Math.Round((CampoTexto * 8e+6),4);
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Megabyte" && ConvesionesDatosFormaCorta2.ToString() == "Byte")
            {
                Resultado = Math.Round((CampoTexto * 1e+6),4);
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Megabyte" && ConvesionesDatosFormaCorta2.ToString() == "Kilobyte")
            {
                Resultado = Math.Round((CampoTexto * 1000),4);
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Megabyte" && ConvesionesDatosFormaCorta2.ToString() == "Gigabyte")
            {
                Resultado = Math.Round((CampoTexto / 1000),4);
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Megabyte" && ConvesionesDatosFormaCorta2.ToString() == "Terabyte")
            {
                Resultado = Math.Round((CampoTexto / 1e+6),4);
            }

            else if (ConvesionesDatosFormaCorta1.ToString() == "Gigabyte" && ConvesionesDatosFormaCorta2.ToString() == "Bit")
            {
                Resultado = Math.Round((CampoTexto * 8e+9),4);
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Gigabyte" && ConvesionesDatosFormaCorta2.ToString() == "Byte")
            {
                Resultado = Math.Round((CampoTexto * 1e+9),4);
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Gigabyte" && ConvesionesDatosFormaCorta2.ToString() == "Kilobyte")
            {
                Resultado = Math.Round((CampoTexto * 1e+6),4);
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Gigabyte" && ConvesionesDatosFormaCorta2.ToString() == "Megabyte")
            {
                Resultado = Math.Round((CampoTexto * 1000),4);
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Gigabyte" && ConvesionesDatosFormaCorta2.ToString() == "Terabyte")
            {
                Resultado = Math.Round((CampoTexto / 1000),4);
            }

            else if (ConvesionesDatosFormaCorta1.ToString() == "Terabyte" && ConvesionesDatosFormaCorta2.ToString() == "Bit")
            {
                Resultado = Math.Round((CampoTexto * 8e+12),4);
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Terabyte" && ConvesionesDatosFormaCorta2.ToString() == "Byte")
            {
                Resultado = Math.Round((CampoTexto * 1e+12),4);
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Terabyte" && ConvesionesDatosFormaCorta2.ToString() == "Kilobyte")
            {
                Resultado = Math.Round((CampoTexto * 1e+9),4);
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Terabyte" && ConvesionesDatosFormaCorta2.ToString() == "Megabyte")
            {
                Resultado = Math.Round((CampoTexto * 1e+6),4);
            }
            else if (ConvesionesDatosFormaCorta1.ToString() == "Terabyte" && ConvesionesDatosFormaCorta2.ToString() == "Gigabyte")
            {
                Resultado = Math.Round((CampoTexto * 1000),4);
            }
            else
            {
                Resultado = 0000;
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
        Gramos , Kilogramo,Onza,Libra
    }

    public enum ConvesionesMasaFormaCorta2
    {
        Gramos, Kilogramo, Onza, Libra
    }


    public enum ConvesionesLongitudFormaCorta1
    {
        Centimetros, Pies, Pulgadas,Metros ,Kilometros,Millas
    }
    public enum ConvesionesLongitudFormaCorta2
    {
        Centimetros, Pies, Pulgadas, Metros, Kilometros, Millas
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