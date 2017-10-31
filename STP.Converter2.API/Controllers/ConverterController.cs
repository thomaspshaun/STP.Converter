using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using STP.Converter2.API.Contracts;
using STP.Converter2.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STP.Converter2.API.Controllers
{
    [Route("api/Converter")]
    public class ConverterController : Controller
    {
        private ILogger<ConverterController> _logger;
        private IConversionService _conversionService;   
        public ConverterController(ILogger<ConverterController> logger, IConversionService conversionService)
        {
            _logger = logger;
            _conversionService = conversionService; 
        }

        [Route("GetConversion")]
        [HttpGet()]
        public Task<LengthConversionResponse> GetLengthConversion(LengthConversionRequest request)
        {
            var reponse = _conversionService.GetConversion(request);
            return reponse; 
        }
    }
}
