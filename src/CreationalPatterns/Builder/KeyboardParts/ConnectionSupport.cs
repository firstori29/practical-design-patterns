namespace Builder.KeyboardParts;

/// <summary>
/// Represents the connection support part of the keyboard.
/// </summary>
internal sealed class ConnectionSupport(string code, string name) : IKeyboardPart
{
    public string Code { get; } = code;
    public string Name { get; } = name;
}
