namespace Abstractions;

[Serializable, Immutable]
public sealed record class Greeting(
    string From,
    DateTimeOffset SentOn);
