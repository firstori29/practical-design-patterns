namespace Singleton;

/// <summary>
/// Represents the singleton class.
/// </summary>
internal sealed class SingletonDemo
{
    /// <summary>
    /// The default constructor.
    /// </summary>
    private SingletonDemo() { }

    private static SingletonDemo? _instance;

    private static readonly Lock _lock = new();

    public string? Value { get; private set; }

    /// <summary>
    /// Gets the singleton instance only once. 
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The instance of <see cref="SingletonDemo"/> class.</returns>
    public static SingletonDemo GetInstance(string value)
    {
        if (_instance is not null)
            return _instance;

        lock (_lock)
        {
            _instance ??= new()
            {
                Value = value
            };
        }

        return _instance;
    }
}
