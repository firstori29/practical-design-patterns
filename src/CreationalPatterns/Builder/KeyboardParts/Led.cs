namespace Builder.KeyboardParts;

/// <summary>
/// Represents the LED backlit part of the keyboard.
/// </summary>
internal sealed class Led(string code, string name) : IKeyboardPart
{
    public string Code { get; } = code;
    public string Name { get; } = name;
}
