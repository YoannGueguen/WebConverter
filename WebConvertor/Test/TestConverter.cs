using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebConvertor.Test
{
    public class TestConverter
    {
        //25/05/2018 Convert km and miles

        //ConverterMilesToKilometer_1.609344 - 
        //The calculation formula makes it possible to convert miles to kilometers.The unit of measurement is described in
        //the formula to specify which mathematical formula corresponds to the code.The conversion value is present in the
        //formula that is declared in static.
        public static double ConverterMilesToKilometer(double miles)
        {
            return miles * 1.609344;
        }
        //ConverterKilometerToMiles_0.621371192 - This calculation formula allows you to convert kilometers to miles.
        public static double ConverterKilometerToMiles(double kilometer)
        {
            return kilometer * 0.621371192;
        }
        //ConverterKilometerToInch_39370.0787401578 - This calculation formula makes it possible to convert kilometers to inches.
        public static double ConverterKilometerToInch(double kilometer)
        {
            return kilometer * 39370.0787401578;
        }
        //ConverterInchToKilometer_0.0000254 - This calculation formula converts inches to kilometers.
        public static double ConverterInchToKilometer(double inch)
        {
            return inch * 0.0000254;
        }
        //ConverterKilometerToFoot_0.0000254 - This calculation formula converts kilometers to foot.
        public static double ConverterKilometerToFoot(double kilometer)
        {
            return kilometer * 0.0000254;
        }
        //ConverterFootToKilometer_3280,839895013128 - This calculation formula converts foot to kilometers.
        public static double ConverterFootToKilometer(double foot)
        {
            return foot * 3280.839895013128;
        }
        //ConveterKilometerToYard_1093,61329834 - This calculation formula converts kilometers to yard. 
        public static double ConverterKilometerToYard(double kilometer)
        {
            return kilometer * 1093.61329834;
        }
        //ConverterKilometerToYard_0,0009144 - This calculation formula converts yard to kilometers.
        public static double ConverterYardToKilometer(double foot)
        {
            return foot * 0.0009144;
        }
    }
}
