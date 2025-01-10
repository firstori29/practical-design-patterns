namespace Builder.Enums;

/// <summary>
/// Represents the PCB type.
/// </summary>
internal enum PCBType
{
    /// <summary>
    /// The hotswap type.
    /// </summary>
    [Description("Hotswap")] Hotswap,

    /// <summary>
    /// The solder type.
    /// </summary>
    [Description("Solder")] Solder
}