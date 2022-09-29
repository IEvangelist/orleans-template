namespace Abstractions;

public interface IHelloGrain : IGrainWithStringKey
{
    Task<string> SayHelloAsync(Greeting greeting);
}