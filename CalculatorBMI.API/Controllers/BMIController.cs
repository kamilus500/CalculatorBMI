using CalculatorBMI.Domain.Interfaces;
using CalculatorBMI.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorBMI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BMIController : ControllerBase
    {
        private readonly ICalculateService _calculateService;
        public BMIController(ICalculateService calculateService)
        {
            _calculateService = calculateService;
        }

        [HttpPost]
        public Result Get(BodyInformation information) => _calculateService.Calculate(information);
    }
}
