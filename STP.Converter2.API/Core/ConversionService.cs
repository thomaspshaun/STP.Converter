using STP.Converter2.API.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using STP.Converter2.API.Models;
using STP.Converter2.API.Controllers;
using Microsoft.Extensions.Logging;
using STP.Converter2.API.Repos;

namespace STP.Converter2.API.Core
{
    public class ConversionService : IConversionService
    {
        private ILogger<ConverterController> _logger;
        private IConversionRepo conversionRepo; 

        public ConversionService(ILogger<ConverterController> logger)
        {
            _logger = logger;
            conversionRepo = new ConversionRepo(); 
        }
        public async Task<LengthConversionResponse> GetConversion(LengthConversionRequest request)
        {
            var response = new LengthConversionResponse(); 

            if (request == null)
            {
                _logger.LogInformation($"ConversionService-GetConversion : Client sent a bad request");// added here to show use of a logger and potentially interaction with the DB. 
                response.Error = $"Client sent a bad request";       
                return response; 
            }

            try
            {
                response.Value = await conversionRepo.GetConversion(request);
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"ConversionService-GetConversion : Conversion failed - {ex.ToString()}");
                response.Error = $"Conversion failed - {ex.ToString()}"; 
                return response;
            }
           
        }


        
       
    }
}
