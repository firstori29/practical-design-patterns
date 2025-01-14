namespace Prototype.Motorbikes;

/// <summary>
/// The sport bike subclass.
/// </summary>
internal sealed class SportBike : Motorbike
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SportBike"/> class.
    /// </summary>
    internal SportBike() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="SportBike"/> class with it type as argument.
    /// </summary>
    /// <param name="sportBike">The sport bike.</param>
    internal SportBike(SportBike sportBike) : base(sportBike)
    {
        TopSpeed = sportBike.TopSpeed;
    }

    /// <summary>
    /// The top speed.
    /// </summary>
    internal int TopSpeed { get; set; }

    /// <inheritdoc />
    internal override Motorbike Clone()
        => new SportBike(this);
}
