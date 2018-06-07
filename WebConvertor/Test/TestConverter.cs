using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebConvertor.Test
{
    public class TestConverter
    {
        protected TestConverter()
        {

        }
        //25/05/2018 Convert km and miles

     //ConverterMilesToKilometer_1.609344 - Formule de calcul qui permet de faire la conversion des miles en 
     //kilomètre. L'unité de mesure est décrite dans la formule afin de préciser à quelle formule mathématique correspond
     //le code. La valeur de conversion est présente dans la formule qui est déclarée en static.
        public static double ConverterMilesToKilometer(double miles)
        {
            return miles * 1.609344;
        }
        //ConverterKilometerToMiles_0.621371192 - Cette formule de calcul permet de convertie des kilomètres en miles.
        public static double ConverterKilometerToMiles(double kilometer)
        {
            return kilometer * 0.621371192;
        }
        //ConverterKilometerToInch_39370.0787401578 - Cette formule de calcul permet de convertir des kilomètres en
        //pouce.
        public static double ConverterKilometerToInch(double kilometer)
        {
            return kilometer * 39370.0787401578;
        }
        //ConverterInchToKilometer_0.0000254 - Cette formule de calcul permet de convertir des pouces en kilomètres.
        public static double ConverterInchToKilometer(double inch)
        {
            return inch * 0.0000254;
        }
        //0,3048
        public static double ConverterKilometerToFoot(double kilometer)
        {
            return kilometer * 0.0000254;
        }
        //3280,839895013128
        public static double ConverterFootToKilometer(double foot)
        {
            return foot * 3280.839895013128;
        }
        //1093,61329834
        public static double ConverterKilometerToYard(double kilometer)
        {
            return kilometer * 1093.61329834;
        }
        //0,0009144
        public static double ConverterYardToKilometer(double foot)
        {
            return foot * 0.0009144;
        }
    }
}

