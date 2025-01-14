namespace AbstractFactory.Motorbikes.Abstractions;

/// <summary>
/// Represents the abstract motorbike class.
/// </summary>
internal abstract class Motorbike
{
    /// <summary>
    /// The motorbike name.
    /// </summary>
    protected abstract string Name { get; }

    /// <summary>
    /// The motorbike brand.
    /// </summary>
    protected abstract Brand Brand { get; }

    /// <summary>
    /// The motorbike displacement.
    /// </summary>
    protected abstract int Displacement { get; }

    /// <summary>
    /// The motorbike color.
    /// </summary>
    protected abstract Color Color { get; }

    /// <summary>
    /// The motorbike wet weight.
    /// </summary>
    protected abstract int WetWeight { get; }

    /// <summary>
    /// The motorbike fuel tank capacity.
    /// </summary>
    protected abstract int FuelTankCapacity { get; }

    /// <summary>
    /// The motorbike consumption rate.
    /// </summary>
    protected abstract float ConsumptionRate { get; }

    /// <summary>
    /// The motorbike ABS support.
    /// </summary>
    protected abstract bool AbsSupport { get; }

    /// <summary>
    /// The motorbike specifications detail.
    /// </summary>
    /// <returns>The motorbike specifications detail.</returns>
    public void MotorBikeSpecs()
    {
        Console.WriteLine("===== Motorbike specifications =====");
        Console.WriteLine($"Name: {Name}.");
        Console.WriteLine($"Brand: {Brand}.");
        Console.WriteLine($"Displacement: {Displacement} cc.");
        Console.WriteLine($"Color: {Color}.");
        Console.WriteLine($"Wet Weight: {WetWeight} kg.");
        Console.WriteLine($"Fuel Tank Capacity: {FuelTankCapacity}L.");
        Console.WriteLine($"Consumption Rate: {ConsumptionRate} km/L.");
        Console.WriteLine($"Abs Support: {(AbsSupport ? "Yes." : "No.")}");
    }

    /// <summary>
    /// The shipping method.
    /// </summary>
    public virtual void ShippingMethod()
        => Console.WriteLine($"Shipping Method: Shipping {Brand} {Name} by sea.\n");

    /// <summary>
    /// The payment method
    /// </summary>
    /// <returns>The specified payment method.</returns>
    public abstract void PaymentMethod();
}
