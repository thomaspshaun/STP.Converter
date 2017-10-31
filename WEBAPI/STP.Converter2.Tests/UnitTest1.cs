using Microsoft.VisualStudio.TestTools.UnitTesting;
using STP.Converter2.API.Models;
using STP.Converter2.API.Repos;
using System;
using static STP.Converter2.API.Enums.ConversionTypeEnums;

namespace STP.Converter2.Tests
{
    [TestClass]
    public class UnitTest1
    {
      
        [TestMethod]
        public void _1000mm_Equals_1m()
        {
            ConversionRepo conversionRepo = new ConversionRepo(); 
            var manualCalc = 1;
            var RepoCalc = conversionRepo.DoConversion(Unit.Milimeter, Unit.Meter, 1000); 
            Assert.AreEqual(manualCalc, 1);
            Assert.AreEqual(RepoCalc, 1);
        }

        [TestMethod]
        public void _1000mm_Equals_39_3701inch()
        {
            ConversionRepo conversionRepo = new ConversionRepo();
            var manualCalc = 1000.0 / 1000.0 * 39.3701; 
            var RepoCalc = conversionRepo.DoConversion(Unit.Milimeter, Unit.Inch, 1000);

            Assert.AreEqual(39.3701, manualCalc);
            Assert.AreEqual(39.3701,RepoCalc);
        }

        [TestMethod]
        public void _500mm_Equals_19_685inch()
        {
            ConversionRepo conversionRepo = new ConversionRepo();
            double manualCalc = (500.0 / 1000.0) * 39.3701;
            var RepoCalc = conversionRepo.DoConversion(Unit.Milimeter, Unit.Inch, 500);

            Assert.AreEqual(19.68505, manualCalc);
            Assert.AreEqual(19.68505, RepoCalc );
        }
    }
}
