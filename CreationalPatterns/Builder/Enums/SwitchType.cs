namespace Builder.Enums;

/// <summary>
/// Represents the switch type.
/// </summary>
internal enum SwitchType
{
    /// <summary>
    /// Clicking sound.
    /// </summary>
    [Description("Clicky")] Clicky,

    /// <summary>
    /// Quiet sound.
    /// </summary>
    [Description("Linear")] Linear,

    /// <summary>
    /// Average sound.
    /// </summary>
    [Description("Tactile")] Tactile
}