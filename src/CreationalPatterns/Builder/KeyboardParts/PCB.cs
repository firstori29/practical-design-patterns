namespace Builder.KeyboardParts;

/// <summary>
/// Represents the PCB part of the keyboard.
/// </summary>
internal sealed class PCB(string code, string name) : KeyboardPart
{
    internal override string Code { get; } = code;
    internal override string Name { get; } = name;
}
