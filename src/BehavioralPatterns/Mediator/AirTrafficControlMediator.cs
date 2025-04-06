namespace Mediator;

/// <summary>
/// Concrete mediator that coordinates landing requests among aircraft.
/// </summary>
internal sealed class AirTrafficControlMediator : IAirTrafficControlMediator
{
    /// <summary>
    /// List of registered aircraft waiting to land.
    /// </summary>
    private readonly List<Aircraft> _aircraftQueue = [];

    /// <inheritdoc />
    public void RegisterAircraft(Aircraft aircraft)
        => _aircraftQueue.Add(aircraft);

    /// <inheritdoc />
    public void NotifyLandingRequest(Aircraft requestingAircraft)
    {
        if (_aircraftQueue[0] == requestingAircraft)
        {
            Console.WriteLine($"Control Tower: {requestingAircraft.CallSign}, you are clear to land.");

            requestingAircraft.Land();

            _aircraftQueue.Remove(requestingAircraft);
        }
        else
        {
            Console.WriteLine($"Control Tower: {requestingAircraft.CallSign}, please wait your turn.\n");
        }
    }
}
