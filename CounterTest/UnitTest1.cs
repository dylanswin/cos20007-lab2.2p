using CounterTask;
namespace CounterTest;

[TestFixture]
public class Tests
{
    [TestCase("Check that incrementing the counter equals a count of 1", 1)]
    public void TestIncrement(string ToCase, int ToCorrect)
    {
        Counter c = new Counter("Test Counter");
        c.Increment();
        Assert.That(c.Ticks, Is.EqualTo(ToCorrect));
    }

    [TestCase("Check that resetting the counter equals a count of 0", 0)]
    public void TestReset(string ToCase, int ToCorrect)
    {
        // Increment first, and then reset for a bit of additional assurance
        Counter c = new Counter("Test Counter");
        c.Increment();

        c.Reset();
        Assert.That(c.Ticks, Is.EqualTo(ToCorrect));
    }

    [TestCase("Assure that the name of counter object is Test Counter", "Test Counter")]
    public void TestGettingName(string ToCase, string ToCorrect)
    {
        Counter c = new Counter(ToCorrect);
        Assert.That(c.Name, Is.EqualTo(ToCorrect));
    }

    [TestCase("Assure that the name of counter object is New Named Test Counter", "New Named Test Counter")]
    public void TestSettingName(string ToCase, string ToCorrect)
    {
        Counter c = new Counter("Test Counter");
        c.Name = ToCorrect;

        Assert.That(c.Name, Is.EqualTo(ToCorrect));
    }

    [Test]
    public void TestGettingTicks()
    {
        Counter c = new Counter("Test Counter");
        Assert.That(c.Ticks, Is.EqualTo(0));
    }
}
