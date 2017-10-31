using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STP.Converter2.API.Models
{
    public class LengthConversionResponse
    {
        public LengthConversionResponse()
        {
            Value = -1;
            Error = ""; 
        }
        public LengthConversionResponse(double value)
        {
            Value = value;
            Error = "";
        }
        public double Value { get; set; }
        public string Error { get; set; }

    }
}
