namespace Mediator.Abstractions;

/// <summary>
/// Defines the mediator interface for communication between aircraft and the control tower.
/// </summary>
internal interface IAirTrafficControlMediator
{
    /// <summary>
    /// Registers an aircraft with the control tower.
    /// </summary>
    /// <param name="aircraft">The aircraft to register.</param>
    void RegisterAircraft(Aircraft aircraft);

    /// <summary>
    /// Notifies the control tower that an aircraft wants to land.
    /// </summary>
    /// <param name="requestingAircraft">The aircraft requesting to land.</param>
    void NotifyLandingRequest(Aircraft requestingAircraft);

}
