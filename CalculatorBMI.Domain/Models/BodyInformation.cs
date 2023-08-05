using CalculatorBMI.Domain.Enums;

namespace CalculatorBMI.Domain.Models
{
    public class BodyInformation
    {
        public double Weight { get; set; }
        public double Height { get; set; }
        public Sex Sex { get; set; }
        public int Age { get; set; }
    }
}
