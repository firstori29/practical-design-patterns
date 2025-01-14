namespace Builder.KeyboardParts;

/// <summary>
/// Represents the keycap profile part of the keyboard.
/// </summary>
internal sealed class KeycapProfile(string code, string name) : IKeyboardPart
{
    public string Code { get; } = code;
    public string Name { get; } = name;
}
