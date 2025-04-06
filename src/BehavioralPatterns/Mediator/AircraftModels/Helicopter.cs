namespace Mediator.AircraftModels;

/// <summary>
/// Represents a helicopter aircraft.
/// </summary>
/// <param name="callSign">The call sign of the helicopter.</param>
/// <param name="controlTower">The control tower to communicate with.</param>
internal sealed class Helicopter(string callSign, IAirTrafficControlMediator controlTower)
    : Aircraft(callSign, controlTower)
{
    /// <inheritdoc />
    public override void RequestLanding()
    {
        Console.WriteLine($"{CallSign} request permission to land.");
        
        _controlTower.NotifyLandingRequest(this);
    }

    /// <inheritdoc />
    public override void Land()
    {
        Console.WriteLine($"{CallSign} has landed.\n");
    }
}
