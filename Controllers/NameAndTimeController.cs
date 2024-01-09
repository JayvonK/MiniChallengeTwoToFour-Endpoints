using Microsoft.AspNetCore.Mvc;
using MiniChallengeTwoToFour_Endpoints.Services.NameAndTime;

namespace MiniChallengeTwoToFour_Endpoints.Controllers;
[ApiController]
[Route("[controller]")]

public class NameAndTimeController : ControllerBase
{
    private readonly INameAndTime _nameAndTime;

    public NameAndTimeController(INameAndTime nameAndTime)
    {
        _nameAndTime = nameAndTime;
    }

    [HttpGet]
    [Route("EnterYourName/{yourName}/EnterTimeYouWokeUp/{timeYouWokeUp}")]

    public string NameAndTime(string yourName, string timeYouWokeUp){
        return _nameAndTime.NameAndTime(yourName, timeYouWokeUp);
    }
}
