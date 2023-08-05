using CalculatorBMI.Domain.Models;

namespace CalculatorBMI.Domain.Interfaces
{
    public interface ICalculateService
    {
        Result Calculate(BodyInformation infos);
    }
}
