using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Converter
    {
        // In this class, properties are declared with their value.The convertId is int because it declares that it is an 
        //integral type that stores values ​​based on sizes.The TypeOfConvert string type refers to the fact that the type 
        //is declared as a simple text.NumbertoConvert and NumberConverted are duplicates to designate that they are 
        //simple types that store floating-point values. Get; set is used to declare the properties that will be used in 
        //the project.

     [Key]
        public int ConvertId { get; set; }

        public string TypeOfConvert { get; set; }

        public double NumbertoConvert { get; set; }

        public double NumberConverted { get; set; }
    }
}
