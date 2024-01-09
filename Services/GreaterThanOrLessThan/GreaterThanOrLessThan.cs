namespace MiniChallengeTwoToFour_Endpoints.Services.GreaterThanOrLessThan;

public class GreaterThanOrLessThan : IGreaterThanOrLessThan
{
    public string GreaterOrLess(double numOne, double numTwo)
    {
        if(numOne > numTwo){
            return $"The first number: {numOne}, is greater than the second number: {numTwo}. \nThe second number: {numTwo}, is less than the first number: {numOne}.";
        } else if (numOne < numTwo){
            return $"The first number: {numOne}, is less than the second number: {numTwo}. \nThe second number: {numTwo}, is greater than the first number: {numOne}.";
        } else {
            return $"The first number: {numOne}, is equal to the second number: {numTwo}. \nThe second number: {numTwo}, is equal to the first number: {numOne}.";
        }
    }
}
