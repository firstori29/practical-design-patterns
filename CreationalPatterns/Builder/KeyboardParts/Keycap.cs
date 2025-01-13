namespace Builder.KeyboardParts;

/// <summary>
/// Represents the keycap part of the keyboard.
/// </summary>
internal sealed class Keycap(string code, string name) : KeyboardPart
{
    internal override string Code { get; } = code;
    internal override string Name { get; } = name;
}