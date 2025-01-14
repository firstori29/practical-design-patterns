namespace Prototype.Motorbikes;

/// <summary>
/// Represents the abstract motorbike class.
/// </summary>
internal abstract class Motorbike
{
    /// <summary>
    /// The default constructor.
    /// </summary>
    protected Motorbike() { }

    /// <summary>
    /// The prototype constructor.
    /// </summary>
    /// <param name="motorbike">The <see cref="Motorbike"/> object.</param>
    protected Motorbike(Motorbike motorbike)
    {
        Name = motorbike.Name;
        Brand = motorbike.Brand;
        Displacement = motorbike.Displacement;
        Color = motorbike.Color;
        WetWeight = motorbike.WetWeight;
        FuelTankCapacity = motorbike.FuelTankCapacity;
        ConsumptionRate = motorbike.ConsumptionRate;
        AbsSupport = motorbike.AbsSupport;
    }

    /// <summary>
    /// The motorbike name.
    /// </summary>
    protected string? Name { get; }

    /// <summary>
    /// The motorbike brand.
    /// </summary>
    protected string? Brand { get; }

    /// <summary>
    /// The motorbike displacement.
    /// </summary>
    protected int Displacement { get; }

    /// <summary>
    /// The motorbike color.
    /// </summary>
    protected string? Color { get; }

    /// <summary>
    /// The motorbike wet weight.
    /// </summary>
    protected int WetWeight { get; }

    /// <summary>
    /// The motorbike fuel tank capacity.
    /// </summary>
    protected int FuelTankCapacity { get; }

    /// <summary>
    /// The motorbike consumption rate.
    /// </summary>
    protected float ConsumptionRate { get; }

    /// <summary>
    /// The motorbike ABS support.
    /// </summary>
    protected bool AbsSupport { get; }

    /// <summary>
    /// Returns the subclass of Motorbike.
    /// </summary>
    /// <returns>A new prototype instance from <see cref="Motorbike"/> class.</returns>
    internal abstract Motorbike Clone();
}
