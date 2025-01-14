namespace Builder.KeyboardParts;

/// <summary>
/// Represents the connection support part of the keyboard.
/// </summary>
internal sealed class ConnectionSupport(string code, string name) : KeyboardPart
{
    internal override string Code { get; } = code;
    internal override string Name { get; } = name;
}
