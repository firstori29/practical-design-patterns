namespace Builder.Abstractions;

/// <summary>
/// Represents the base part class of the keyboard.
/// </summary>
internal interface IKeyboardPart
{
    /// <summary>
    /// The base part code of keyboard.
    /// </summary>
    internal string Code { get; }

    /// <summary>
    /// The base part name of keyboard.
    /// </summary>
    internal string Name { get; }
}
