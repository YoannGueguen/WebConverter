using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Converter
    {
        //Dans cette classe, les propriétés sont déclarées avec leur valeur. Le convertId est en int car il déclare
        //que c'est un type intégral qui stock les valeurs en fonction des tailles. Le type string du TypeOfConvert
        //désigne le fait que le type est déclaré comme étant un simple texte. NumbertoConvert et NumberConverted
        //sont en double afin de désigner qu'ils sont des types simples qui stockent des valeur à virgule flottantes.
        //Get;set permet de déclarer les propriétés qui seront utilisées dans le projet.
        [Key]
        public int ConvertId { get; set; }

        public string TypeOfConvert { get; set; }

        public double NumbertoConvert { get; set; }

        public double NumberConverted { get; set; }
    }
}
