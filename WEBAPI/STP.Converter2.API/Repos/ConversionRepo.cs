using STP.Converter2.API.Classes;
using STP.Converter2.API.Contracts;
using STP.Converter2.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static STP.Converter2.API.Enums.ConversionTypeEnums;

namespace STP.Converter2.API.Repos
{
    public class ConversionRepo : IConversionRepo
    {

        async Task<double> IConversionRepo.GetConversion(LengthConversionRequest request)
        {
            return DoConversion(request.From, request.To, request.Value); 
        }

        public double DoConversion(Unit From, Unit To, double value)
        {
            double result = 0;
            bool fromImperial = false; // having this will allow conversion within imperial and within metric
            bool fromMetric = false;   // having this will allow conversion within imperial and within metric
            Metric meters;
            Imperial inches;

            switch (From)
            {
                case Unit.Milimeter: value = value * Metric.Milimeter.ToMeters(); fromMetric = true; break;
                case Unit.Centimeter: value = value * Metric.Centimeter.ToMeters(); fromMetric = true; break;
                case Unit.Kilometer: value = value * Metric.Kilometer.ToMeters(); fromMetric = true; break;
                case Unit.Meter: value = value * Metric.Meter.ToMeters(); fromMetric = true; break;
                case Unit.Foot: value = value * Imperial.Foot.ToInches(); fromImperial = true; break;
                case Unit.Yard: value = value * Imperial.Yard.ToInches(); fromImperial = true; break;
                case Unit.Mile: value = value * Imperial.Mile.ToInches(); fromImperial = true; break;
                case Unit.Inch: value = value * Imperial.Inch.ToInches(); fromImperial = true; break;
                default:
                    break;
            }

            meters = new Metric(value);
            inches = new Imperial(value);

            switch (To)
            {
                case Unit.Milimeter: result = fromImperial ? inches.ToMetricDistance().ToMilimeters() : meters.ToMilimeters(); break;
                case Unit.Centimeter: result = fromImperial ? inches.ToMetricDistance().ToCentimeters() : meters.ToCentimeters(); break;
                case Unit.Kilometer: result = fromImperial ? inches.ToMetricDistance().ToKilometers() : meters.ToKilometers(); break;
                case Unit.Meter: result = fromImperial ? inches.ToMetricDistance().ToMeters() : meters.ToMeters(); break;
                case Unit.Foot: result = fromMetric ? meters.ToImperialDistance().ToFeet() : inches.ToFeet(); break;
                case Unit.Yard: result = fromMetric ? meters.ToImperialDistance().ToYards() : inches.ToYards(); break;
                case Unit.Mile: result = fromMetric ? meters.ToImperialDistance().ToMiles() : inches.ToMiles(); break;
                case Unit.Inch: result = fromMetric ? meters.ToImperialDistance().ToInches() : inches.ToInches(); break;
                default:
                    break;
            }
            return result;
        }

    }
}
