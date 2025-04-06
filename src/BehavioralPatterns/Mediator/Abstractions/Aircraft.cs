namespace Mediator.Abstractions;

/// <summary>
/// Represents a base aircraft that interacts with the control tower.
/// </summary>
internal abstract class Aircraft
{
    /// <summary>
    /// Reference to the control tower (mediator).
    /// </summary>
    protected readonly IAirTrafficControlMediator _controlTower;

    /// <summary>
    /// The unique call sign of the aircraft.
    /// </summary>
    public string CallSign { get; }

    /// <summary>
    /// Initializes a new instance of the aircraft.
    /// </summary>
    /// <param name="callSign">The call sign of the aircraft.</param>
    /// <param name="controlTower">The control tower to communicate with.</param>
    protected Aircraft(string callSign, IAirTrafficControlMediator controlTower)
    {
        CallSign = callSign;
        _controlTower = controlTower;
        _controlTower.RegisterAircraft(this);
    }

    /// <summary>
    /// Sends a landing request to the control tower.
    /// </summary>
    public abstract void RequestLanding();

    /// <summary>
    /// Simulates the aircraft landing.
    /// </summary>
    public abstract void Land();
}
