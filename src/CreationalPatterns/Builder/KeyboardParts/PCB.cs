namespace Builder.KeyboardParts;

/// <summary>
/// Represents the PCB part of the keyboard.
/// </summary>
internal sealed class Pcb(string code, string name) : IKeyboardPart
{
    public string Code { get; } = code;
    public string Name { get; } = name;
}
