namespace Prototype.Motorbikes;

/// <summary>
/// The naked bike subclass.
/// </summary>
internal sealed class NakedBike : Motorbike
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClassicBike"/> class.
    /// </summary>
    internal NakedBike() { }

    /// <inheritdoc />
    internal override Motorbike Clone()
        => new NakedBike();
}
