using CalculatorBMI.Domain.Models;

namespace CalculatorBMI.UI.Services
{

    public interface IResultService
    {
        public Result GetResult();

        public void SetResult(Result result);

        public void ClearResult();
    }

    public class ResultService : IResultService
    {
        private Result Result;

        public void ClearResult()
        {
            Result = null;
        }

        public Result GetResult() => Result;

        public void SetResult(Result result)
        {
            Result = result;
        }
    }
}
