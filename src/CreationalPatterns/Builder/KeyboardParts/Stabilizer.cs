namespace Builder.KeyboardParts;

/// <summary>
/// Represents the stabilizer part of the keyboard.
/// </summary>
internal sealed class Stabilizer(string code, string name) : IKeyboardPart
{
    public string Code { get; } = code;
    public string Name { get; } = name;
}
