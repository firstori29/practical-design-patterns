namespace Builder.KeyboardParts;

/// <summary>
/// Represents the case part of the keyboard.
/// </summary>
internal sealed class Case(string code, string name) : IKeyboardPart
{
    public string Code { get; } = code;
    public string Name { get; } = name;
}
