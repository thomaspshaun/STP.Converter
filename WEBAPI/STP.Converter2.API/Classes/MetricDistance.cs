using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STP.Converter2.API.Classes
{
    public class Metric
    {
        /// <summary>
        ///  Conversions taken from the Internet
        ///  All conversions are in relations to meters. 
        /// </summary>
        /// 
        public static readonly Metric Milimeter = new Metric(0.001);
        public static readonly Metric Centimeter = new Metric(0.01);
        public static readonly Metric Meter = new Metric(1.0);
        public static readonly Metric Kilometer = new Metric(1000.0);

        private double _meters;

        public Metric(double meters)
        {
            _meters = meters;
        }

        public double ToMilimeters()
        {
            return _meters / Milimeter._meters;
        }

        public double ToCentimeters()
        {
            return _meters / Centimeter._meters;
        }
      
        public double ToMeters()
        {
            return _meters;
        }

        public double ToKilometers()
        {
            return _meters / Kilometer._meters;
        }

        public Imperial ToImperialDistance()
        {
            return new Imperial(_meters * 39.3701);
        }

       
    }
}
