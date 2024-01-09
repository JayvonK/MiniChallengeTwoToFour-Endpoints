using Microsoft.AspNetCore.Mvc;
using MiniChallengeTwoToFour_Endpoints.Services.GreaterThanOrLessThan;

namespace MiniChallengeTwoToFour_Endpoints.Controllers;
[ApiController]
[Route("[controller]")]

public class GreaterThanOrLessThanController : ControllerBase
{
    private readonly IGreaterThanOrLessThan _greaterThanOrLessThan;

    public GreaterThanOrLessThanController(IGreaterThanOrLessThan greaterThanOrLessThan)
    {
        _greaterThanOrLessThan = greaterThanOrLessThan;
    }

    [HttpGet]
    [Route("EnterTwoNumbers/{firstNumber}/{secondNumber}")]
    public string GreaterOrLess(string firstNumber, string secondNumber){
        return _greaterThanOrLessThan.GreaterOrLess(firstNumber, secondNumber);
    }
}
