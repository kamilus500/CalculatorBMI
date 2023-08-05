using CalculatorBMI.Domain.Enums;
using CalculatorBMI.Domain.Interfaces;
using CalculatorBMI.Domain.Models;

namespace CalculatorBMI.Infrastructure.Services
{
    public class CalculateService : ICalculateService
    {
        public Result Calculate(BodyInformation infos)
        {
            var bmi = CalculateBMI(infos.Weight, infos.Height);

            return new Result(bmi, MapBodyMaxx(bmi));
        }

        private double CalculateBMI(double weight, double height)
            => Math.Round(weight / Math.Pow(height / 100, 2),2);

        private BodyMassIndex MapBodyMaxx(double bmi)
        {
            if (bmi < 18.5) 
                return BodyMassIndex.UnderWeight;

            if (bmi > 18.5 && bmi <= 24.9) 
                return BodyMassIndex.Normal;

            if (bmi >= 25.0 && bmi <= 29.9) 
                return BodyMassIndex.Overweight;

            if (bmi >= 30.0 && bmi <= 34.9) 
                return BodyMassIndex.Obese;

            return BodyMassIndex.ExtremlyObese;
        }
    }
}
