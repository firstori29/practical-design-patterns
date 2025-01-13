namespace Builder.KeyboardParts;

/// <summary>
/// Represents the stabilizer part of the keyboard.
/// </summary>
internal sealed class Stabilizer(string code, string name) : KeyboardPart
{
    internal override string Code { get; } = code;
    internal override string Name { get; } = name;
}