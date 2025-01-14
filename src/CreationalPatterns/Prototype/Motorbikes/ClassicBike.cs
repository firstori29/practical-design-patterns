namespace Prototype.Motorbikes;

/// <summary>
/// Represents the classic bike subclass.
/// </summary>
internal sealed class ClassicBike : Motorbike
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClassicBike"/> class.
    /// </summary>
    internal ClassicBike() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="ClassicBike"/> class with it type as argument.
    /// </summary>
    /// <param name="classicBike">The classic bike.</param>
    internal ClassicBike(ClassicBike classicBike) : base(classicBike)
    {
        HeadlightType = classicBike.HeadlightType;
    }

    /// <summary>
    /// The headlight type.
    /// </summary>
    internal string? HeadlightType { get; set; }

    /// <inheritdoc />
    internal override Motorbike Clone()
        => new ClassicBike(this);
}
