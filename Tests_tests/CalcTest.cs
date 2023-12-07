using Tests;

namespace Tests_tests;

[TestFixture] // Helps C# understand this is a test
public class CalcTest
{
    private CalcT Value1;  //Declare variable to be used on all instances
    [SetUp]   //Method name  we will use to create our instance

    public void SetUp(){  //Method to create instance of our class to be tested
        Value1=new CalcT();
    }
    [Test]
    public void GetProduct(){
        var product1= new CalcT();

        var productResult=product1.Calcprod(10,7);

        Assert.That(productResult, Is.EqualTo(70));
    }

    //Parameterized tests
    [Test]
    [TestCase(12,7,12)]  //Annotation to pass our parameters and expected output
    [TestCase(12,12,12)]
    [TestCase(7,12,12)]
    
    public void GetMax_FromArguements(int k, int n, int output){
        
        var MaxNum= Value1.MaxiNum(k,n);
        Assert.That(MaxNum, Is.EqualTo(output));
    }

    [Test]
    [Ignore("Repetition")] // This method test will be ignored, we passed a reason on ignore method
    public void return_min(){
        // var min1= new CalcT();
        var minNum= Value1.MaxiNum(7,10);
        Assert.That(minNum, Is.EqualTo(10));

    }

    [Test]
    [Ignore("Repetition")] // This method test will be ignored, we passed a reason on ignore method
    public void Return_either(){
        // var Eq= new CalcT();
        var Eq1=Value1.MaxiNum(10,10);
        Assert.That(Eq1, Is.EqualTo(10));

    }

}
