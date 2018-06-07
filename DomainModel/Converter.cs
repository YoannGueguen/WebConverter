using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Converter
    {
        [Key]
        public int ConvertId { get; set; }

        public string TypeOfConvert { get; set; }

        public double NumbertoConvert { get; set; }

        public double NumberConverted { get; set; }
    }
}
