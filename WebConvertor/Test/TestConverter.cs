using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebConvertor.Test
{
    public class TestConverter
    {
        //25/05/2018 Convert km and miles

        //ConverterMilesToKilometer_1.609344 - The calculation formula makes it possible to convert miles to kilometers.
        //The unit of measurement is described in the formula to specify which mathematical formula corresponds to the 
        //code. The conversion value is present in the formula that is declared in static.

        //Unit tests are carried out to verify the correct operation of the codes. With the AAA method. You have to define objects
        //and variables. Then execute the code that we want to test to verify that the result is the expected one.
        public static double ConverterMilesToKilometer(double miles)
        {
            //Arrange
            double milesToKilometer = 1.609344;

            double resultMilesToKilometer = 0;

            //Act
            resultMilesToKilometer = miles * milesToKilometer;

            //Assert
            return resultMilesToKilometer;
        }
        //ConverterKilometerToMiles_0.621371192 - This calculation formula allows you to convert kilometers to miles.
        public static double ConverterKilometerToMiles(double kilometer)
        {
            //Arrange
            double kilometerToMiles = 0.621371192;

            double resultKilometerToMiles = 0;

            //Act
            resultKilometerToMiles = kilometer * kilometerToMiles;

            //Assert
            return resultKilometerToMiles;
        }

        //ConverterKilometerToInch_39370.0787401578 - This calculation formula allows you to convert kilometers to inches.
        public static double ConverterKilometerToInch(double kilometer)
        {
            //Arrange
            double kilometerToInch = 39370.0787401578;

            double resultKilometerToInch = 0;

            //Act
            resultKilometerToInch = kilometer * kilometerToInch;

            //Assert
            return resultKilometerToInch;
        }
        //ConverterInchToKilometer_0.3048 - This calculation formula allows you to convert inches to kilometers.
        public static double ConverterInchToKilometer(double inch)
        {
            //Arrange
            double inchToKilometer = 0.3048;

            double resultInchToKilometer = 0;

            //Act
            resultInchToKilometer = inch * inchToKilometer;

            //Assert
            return resultInchToKilometer;
        }
        //ConverterFootToKilometer_3280.0839895013128 - This calculation formula allows you to convert foot to kilometers.
        public static double ConverterFootToKilometer(double foot)
        {
            //Arrange
            double footToKilometer = 3280.839895013128;

            double resultFootToKilometer = 0;

            //Act
            resultFootToKilometer = foot * footToKilometer;

            //Assert
            return resultFootToKilometer;
        }
        //ConverterKilometerToFoot_0.0000254 - This calculation formula allows you to convert kilometers to foot.
        public static double ConverterKilometerToFoot(double kilometer)
        {
            //Arrange
            double kilometerToFoot = 0.0000254;

            double resultKilometerToFoot = 0;

            //Act
            resultKilometerToFoot = kilometer * kilometerToFoot;

            //Assert
            return resultKilometerToFoot;
        }

        //ConverterKilometerToYard_1093.61329834 - This calculation formula allows you to convert kilometers to yard.
        public static double ConverterKilometerToYard(double kilometer)
        {
            //Arrange
            double kilometerToYard = 1093.61329834;

            double resultKilometerToYard = 0;

            //Act
            resultKilometerToYard = kilometer * kilometerToYard;

            //Assert
            return resultKilometerToYard;
        }
        //ConverterYardToKilometer_0.0009144 - This calculation formula allows you to convert yard to kilometers.
        public static double ConverterYardToKilometer(double yard)
        {
            //Arrange
            double yardToKilometer = 0.0009144;

            double resultYardToKilometer = 0;

            //Act
            resultYardToKilometer = yard * yardToKilometer;

            //Assert
            return resultYardToKilometer;
        }
    }
}

