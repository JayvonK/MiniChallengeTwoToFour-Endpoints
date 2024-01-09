using Microsoft.AspNetCore.Mvc;
using MiniChallengeTwoToFour_Endpoints.Services.Numbers;

namespace MiniChallengeTwoToFour_Endpoints.Controllers;
    [ApiController]
    [Route("[controller]")]
    public class AddTwoNumbersController : ControllerBase
    {
    private readonly INumbers _numbers;

    public AddTwoNumbersController(INumbers numbers)
        {
        _numbers = numbers;
    }

    [HttpGet]
    [Route("EnterTwoNumbers/{firstNumber}/{secondNumber}")]
    public string AddTwoNumbers(double firstNumber, double secondNumber){
        return _numbers.AddTwoNumbers(firstNumber, secondNumber);
    }
    }
