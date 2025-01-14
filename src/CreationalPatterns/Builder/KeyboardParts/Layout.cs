namespace Builder.KeyboardParts;

/// <summary>
/// Represents the layout part of the keyboard.
/// </summary>
internal sealed class Layout(string code, string name) : IKeyboardPart
{
    public string Code { get; } = code;
    public string Name { get; } = name;
}
