namespace MiniChallengeTwoToFour_Endpoints.Services.Numbers;

public class Numbers : INumbers
{
    public string AddTwoNumbers(string numOne, string numTwo)
    {
        if(double.TryParse(numOne, out double num) && double.TryParse(numTwo, out double num2)){
            return $"The sum of {numOne} and {numTwo} is {num + num2}.";
        } else {
            return "Error, please enter in numbers for both parameters.";
        }
        
    }
}
