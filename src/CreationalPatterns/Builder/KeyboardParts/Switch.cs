namespace Builder.KeyboardParts;

/// <summary>
/// Represents the switch part of the keyboard.
/// </summary>
internal sealed class Switch(string code, string name) : IKeyboardPart
{
    public string Code { get; } = code;
    public string Name { get; } = name;
}
