namespace Mediator.AircraftModels;

/// <summary>
/// Represents a biplane aircraft.
/// </summary>
/// <param name="callSign">The call sign of the biplane.</param>
/// <param name="controlTower">The control tower to communicate with.</param>
internal sealed class Biplane(string callSign, IAirTrafficControlMediator controlTower)
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
