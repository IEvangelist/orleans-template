using Abstractions;

namespace Grains.Tests;

public class HelloGrainTests
{
    [Fact]
    public async Task TestGreeting()
    {
        IHelloGrain sut = new HelloGrain();

        var actual = await sut.SayHelloAsync(
            new Greeting("David", new DateTime(2022, 9, 29)));

        var expected = """
            Hello, David.
            Welcome to Microsoft Orleans!
            Sent on Sep 29, 2022.
            """;

        Assert.Equal(expected, actual);
    }
}