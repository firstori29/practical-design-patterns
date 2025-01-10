namespace Builder.Enums;

/// <summary>
/// Represents the led type.
/// </summary>
internal enum LedType
{
    /// <summary>
    /// The Monochrome led type.
    /// </summary>
    [Description("Monochrome")] Monochrome,

    /// <summary>
    /// The RGB LED type.
    /// </summary>
    [Description("RGB")] RGB,

    /// <summary>
    /// The Rainbow led type.
    /// </summary>
    [Description("Rainbow")] Rainbow
}