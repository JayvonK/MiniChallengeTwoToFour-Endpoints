namespace MiniChallengeTwoToFour_Endpoints.Services.NameAndTime;

public class NameAndTime : INameAndTime
{
    string INameAndTime.NameAndTime(string name, string time)
    {
        return $"Hello there user. Your name is {name}, nice to meet you. I can also see that you woke up at {time} today, cooooool.";
    }
}
