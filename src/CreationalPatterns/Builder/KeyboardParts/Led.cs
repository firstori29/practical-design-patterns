namespace Builder.KeyboardParts;

/// <summary>
/// Represents the LED backlit part of the keyboard.
/// </summary>
internal sealed class Led(string code, string name) : KeyboardPart
{
    internal override string Code { get; } = code;
    internal override string Name { get; } = name;
}
