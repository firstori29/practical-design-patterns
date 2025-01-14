namespace Builder.KeyboardParts;

/// <summary>
/// Represents the keycap part of the keyboard.
/// </summary>
internal sealed class Keycap(string code, string name) : IKeyboardPart
{
    public string Code { get; } = code;
    public string Name { get; } = name;
}
