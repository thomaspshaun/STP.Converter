using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STP.Converter2.API.Classes
{
    public class Imperial
    {
        /// <summary>
        ///  Conversions taken from the Internet
        ///  All conversions are in relations to inches. 
        /// </summary>

        public static readonly Imperial Inch = new Imperial(1.0);
        public static readonly Imperial Foot = new Imperial(12.0);
        public static readonly Imperial Yard = new Imperial(36.0);
        public static readonly Imperial Mile = new Imperial(63360.0);

        private double _inches;

        public Imperial(double inches)
        {
            _inches = inches;
        }

        public double ToInches()
        {
            return _inches;
        }

        public double ToFeet()
        {
            return _inches / Foot._inches;
        }

        public double ToYards()
        {
            return _inches / Yard._inches;
        }

        public double ToMiles()
        {
            return _inches / Mile._inches;
        }

        public Metric ToMetricDistance()
        {
            return new Metric(_inches * 0.0254);
        }

    }
}
