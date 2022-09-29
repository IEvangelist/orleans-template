namespace Abstractions.Tests;

// TODO: This test project is just for template purposes.
// Obviously customize to your liking and write real tests.
public class GreetingTests
{
    [Fact]
    public void TestGreeting()
    {
        Greeting sut = new("David", new DateTime(2022, 9, 29));

        var (actualFrom, actualSentOn) = sut;

        Assert.Equal("David", actualFrom);
        Assert.Equal(new DateTime(2022, 9, 29), actualSentOn);
    }
}