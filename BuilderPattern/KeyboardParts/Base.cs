namespace BuilderPattern.KeyboardParts;

/// <summary>
/// Represents the base part class of the keyboard.
/// </summary>
internal class Base
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
    public string Code { get; set; }

    /// <summary>
    /// The base part name of keyboard.
    /// </summary>
    public string Name { get; set; }
}