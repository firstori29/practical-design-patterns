namespace Builder.Enums;

/// <summary>
/// Represents the layout type.
/// </summary>
internal enum LayoutType
{
    /// <summary>
    /// The sixty percent layout type.
    /// </summary>
    [Description("60%")] Sixty = 60,

    /// <summary>
    /// The seventy-five percent layout type.
    /// </summary>
    [Description("75%")] SeventyFive = 75,

    /// <summary>
    /// The Ten Key Less layout type.
    /// </summary>
    [Description("87 keys")] TKL = 87,

    /// <summary>
    /// The full size layout type.
    /// </summary>
    [Description("104 keys")] FullSize = 104
}
