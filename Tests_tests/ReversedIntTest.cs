using Tests;

namespace Tests_tests;

[TestFixture] //This annotation indicates that this class focusses  on testing
public class ReversedIntTest
{
    [Test]  //Annotation for methods
    public void greet_return_helloWorld() //all testing methods should be void
    { 
        //arrange act assertt

        //arrange - create an instance of the class to be tested

        var test1= new ReverseInt();

        //Act - called the method to be 

        var testResult=test1.Message();

        //Assert - confirm the expected result
        Assert.That(testResult, Does.Contain("wewe"));

    }

}
