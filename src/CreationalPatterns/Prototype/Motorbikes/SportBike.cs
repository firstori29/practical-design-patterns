namespace Prototype.Motorbikes;

/// <summary>
/// The sport bike subclass.
/// </summary>
internal sealed class SportBike(SportBike sportBike) : Motorbike(sportBike)
{
    /// <summary>
    /// The top speed.
    /// </summary>
    internal int TopSpeed { get; set; } = sportBike.TopSpeed;

    /// <inheritdoc />
    internal override Motorbike Clone()
        => new SportBike(this);
}
