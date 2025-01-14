namespace Builder.KeyboardParts;

/// <summary>
/// Represents the keycap profile part of the keyboard.
/// </summary>
internal sealed class KeycapProfile(string code, string name) : KeyboardPart
{
    internal override string Code { get; } = code;
    internal override string Name { get; } = name;
}
