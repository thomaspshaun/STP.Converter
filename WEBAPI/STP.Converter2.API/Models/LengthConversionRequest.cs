using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static STP.Converter2.API.Enums.ConversionTypeEnums;

namespace STP.Converter2.API.Models
{
    public class LengthConversionRequest
    {
        public Unit From { get; set; }
        public Unit To {get; set; }
        public double Value { get; set; }


    }
}
