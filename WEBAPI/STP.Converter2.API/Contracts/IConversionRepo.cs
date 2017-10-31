using STP.Converter2.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STP.Converter2.API.Contracts
{
    interface IConversionRepo
    {
         Task<double> GetConversion(LengthConversionRequest request); 
    }
}
