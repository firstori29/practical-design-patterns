namespace Builder.KeyboardParts;

/// <summary>
/// Represents the plate part of the keyboard.
/// </summary>
internal sealed class Plate(string code, string name) : IKeyboardPart
{
    public string Code { get; } = code;
    public string Name { get; } = name;
}
