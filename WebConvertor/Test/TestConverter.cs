using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebConvertor.Test
{
    public class TestConverter
    {
        //25/05/2018 Convert km and miles

     //Converter_miles_to_kilometer_1.609344 - Formule de calcul qui permet de faire la conversion des miles en 
     //kilomètre. L'unité de mesure est décrite dans la formule afin de préciser à quelle formule mathématique correspond
     //le code. La valeur de conversion est présente dans la formule qui est déclarée en static.
        public static double GivenConvertMilesToKilometers(double miles)
        {
            return miles * 1.609344;
        }
        //Converter_kilometer_to_miles_0.621371192 - Cette formule de calcul permet de faire l'inverse de la formule du
        //dessus : il permet de convertir des kilomètres en miles.
        public static double GivenConvertKilometersToMiles(double kilometers)
        {
            return kilometers * 0.621371192;
        }
        //Converter_kilometer_to_inch_39370.0787401578
        public static double GivenConvertKilometersToInch(double kilometers)
        {
            return kilometers * 39370.0787401578;
        }
        //Converter_inch_to_kilometer_0.0000254
        public static double GivenConvertInchToKilometers(double inch)
        {
            return inch * 0.0000254;
        }
    }
}
