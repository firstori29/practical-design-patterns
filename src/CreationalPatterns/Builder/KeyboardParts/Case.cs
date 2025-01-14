namespace Builder.KeyboardParts;

/// <summary>
/// Represents the case part of the keyboard.
/// </summary>
internal sealed class Case(string code, string name) : KeyboardPart
{
    internal override string Code { get; } = code;
    internal override string Name { get; } = name;
}
