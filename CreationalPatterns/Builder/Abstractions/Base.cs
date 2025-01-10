namespace Builder.Abstractions;

/// <summary>
/// Represents the base part class of the keyboard.
/// </summary>
internal abstract class Base
{
    /// <summary>
    /// Initializes a new instance of the base class.
    /// </summary>
    protected Base(string code, string name)
    {
        Code = code;
        Name = name;
    }

    /// <summary>
    /// The base part code of keyboard.
    /// </summary>
    internal string Code { get; private set; }

    /// <summary>
    /// The base part name of keyboard.
    /// </summary>
    internal string Name { get; private set; }
}