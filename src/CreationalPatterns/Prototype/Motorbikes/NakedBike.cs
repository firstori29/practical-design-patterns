namespace Prototype.Motorbikes;

/// <summary>
/// The naked bike subclass.
/// </summary>
internal sealed class NakedBike : Motorbike
{
    internal NakedBike() { }

    internal override Motorbike Clone()
        => new NakedBike();
}
