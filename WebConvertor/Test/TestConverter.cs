using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebConvertor.Test
{
    public class TestConverter
    {
        //25/05/2018 Convert km and miles

        public double ConvertMilesToKilometers(double miles)
        {
            return miles * 1.609344;
        }

        public double ConvertKilometersToMiles(double kilometers)
        {
            return kilometers * 0.621371192;
        }
        public double ConvertKilometersToInch(double kilometers)
        {
            return kilometers * 39370.0787401578;
        }

        public double ConvertInchToKilometers(double inch)
        {
            return inch * 0.0000254;
        }
    }
}
