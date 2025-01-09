namespace BuilderPattern.KeyboardParts;

/// <summary>
/// Represents the switch part of the keyboard.
/// </summary>
/// <param name="code"></param>
/// <param name="name"></param>
internal sealed class Switch(string code, string name) : Base(code, name);