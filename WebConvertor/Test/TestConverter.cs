using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebConvertor.Test
{
    public class TestConverter
    {
        //25/05/2018 Convert km and miles
        //Converter_miles_to_kilometer_1.609344 - Formule de calcul qui permet 
        public static double GivenConvertMilesToKilometers(double miles)
        {
            return miles * 1.609344;
        }
        //Converter_kilometer_to_miles_0.621371192
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
