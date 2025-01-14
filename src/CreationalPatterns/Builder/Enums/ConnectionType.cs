namespace Builder.Enums;

/// <summary>
/// Represents the connection type.
/// </summary>
internal enum ConnectionType
{
    /// <summary>
    /// Wire connection type like cable.
    /// </summary>
    [Description("Wire")] Wire,

    /// <summary>
    /// Wireless connection type like bluetooth.
    /// </summary>
    [Description("Wireless")] Wireless,

    /// <summary>
    /// Supports both wire and wireless connection.
    /// </summary>
    [Description("Both wire and wireless")]
    BothWireAndWireless
}
