namespace MiniChallengeTwoToFour_Endpoints.Services.Numbers;

public class Numbers : INumbers
{
    public string AddTwoNumbers(double numOne, double numTwo)
    {
        return $"The sum of {numOne} and {numTwo} is {numOne + numTwo}.";
    }
}
