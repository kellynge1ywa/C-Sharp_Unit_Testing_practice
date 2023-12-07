using Tests;

namespace Tests_tests;
[TestFixture]
public class TownTest
{
    [Test]
    public void Test_Added_Town(){
        var town1= new Towns();
        town1.AddTown("Kitale");
        // Assert.That(town1.TownNames.Count, Is.EqualTo(1));
        Assert.That(town1.TownNames.Contains("Kitale"), Is.EqualTo(true));
        // Assert.That(town1.TownNames, Is.EquivalentTo(new List<string>(){"Kitale"}));

    }

    [Test]
    [TestCase(null)]
    [TestCase("")]
    [TestCase(" ")]

    public void Exception_test(string TownName){
        var town2= new Towns();
        Assert.That(()=>town2.AddTown(TownName), Throws.TypeOf<ArgumentNullException>());

    }

}
