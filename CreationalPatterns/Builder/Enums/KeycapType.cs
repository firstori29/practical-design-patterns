namespace Builder.Enums;

/// <summary>
/// Represents the keycap type.
/// </summary>
internal enum KeycapType
{
    /// <summary>
    /// ABS thermoplastic polymer keycap.
    /// </summary>
    [Description("ABS")] ABS = PlasticType.ABS,

    /// <summary>
    /// PBT thermoplastic polymer keycap.
    /// </summary>
    [Description("PBT")] PBT = PlasticType.PBT
}