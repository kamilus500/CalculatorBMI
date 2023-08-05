using CalculatorBMI.Domain.Enums;

namespace CalculatorBMI.Domain.Models
{
    public class Result
    {
        public double BMI { get; set; }
        public BodyMassIndex MassIndex { get; set; }

        public Result(double bmi, BodyMassIndex massIndex)
        {
            BMI = bmi;
            MassIndex = massIndex;
        }
    }
}
