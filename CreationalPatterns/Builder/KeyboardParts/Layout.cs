namespace Builder.KeyboardParts;

/// <summary>
/// Represents the layout part of the keyboard.
/// </summary>
internal sealed class Layout(string code, string name) : KeyboardPart
{
    internal override string Code { get; } = code;
    internal override string Name { get; } = name;
}