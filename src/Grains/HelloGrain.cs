using Abstractions;

namespace Grains;

public sealed class HelloGrain : Grain, IHelloGrain
{
    public Task<string> SayHelloAsync(Greeting greeting) =>
        Task.FromResult($"""
            Hello, {greeting.From}.
            Welcome to Microsoft Orleans!
            Sent on {greeting.SentOn:MMM d, yyyy}.
            """);
}