namespace Builder.KeyboardParts;

/// <summary>
/// Represents the switch part of the keyboard.
/// </summary>
internal sealed class Switch(string code, string name) : KeyboardPart
{
    internal override string Code { get; } = code;
    internal override string Name { get; } = name;
}
