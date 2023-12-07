namespace Tests;

public class FizzBuzz
{
    public string Fizz(int maxNumber)
    {

        if ((maxNumber % 5 == 0) && (maxNumber % 3 == 0))
        {
            return "This is a Fizzbuzz!!";
        }
        else if (maxNumber % 5 == 0)
        {
            return "This is Fizz!!";
        }
        else if (maxNumber % 3 == 0)
        {
            return "This is Buzz!!";
        }
        else
        {
            return maxNumber.ToString();
        }


    }

}
