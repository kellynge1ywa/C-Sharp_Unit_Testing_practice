using Tests;

namespace Tests_tests;
[TestFixture]
public class FizzBuzzTest
{
    [Test]
    [TestCase(15,"This is a Fizzbuzz!!")]
    [TestCase(10,"This is Fizz!!")]
    [TestCase(12,"This is Buzz!!")]
    [TestCase(2,"2")]
    public void CheckBuzz(int maxNumber, string output){
        var output1=new FizzBuzz();
        var word=output1.Fizz(maxNumber);
        Assert.That(word, Is.EqualTo(output));

    }

}
