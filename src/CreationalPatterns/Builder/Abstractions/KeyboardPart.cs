namespace Builder.Abstractions;

/// <summary>
/// Represents the base part class of the keyboard.
/// </summary>
internal abstract class KeyboardPart
{
    /// <summary>
    /// The base part code of keyboard.
    /// </summary>
    internal abstract string Code { get; }

    /// <summary>
    /// The base part name of keyboard.
    /// </summary>
    internal abstract string Name { get; }
}
