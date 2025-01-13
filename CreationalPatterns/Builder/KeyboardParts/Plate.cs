namespace Builder.KeyboardParts;

/// <summary>
/// Represents the plate part of the keyboard.
/// </summary>
internal sealed class Plate(string code, string name) : KeyboardPart
{
    internal override string Code { get; } = code;
    internal override string Name { get; } = name;
}