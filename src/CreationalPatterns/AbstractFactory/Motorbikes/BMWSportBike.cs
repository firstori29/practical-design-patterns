namespace AbstractFactory.Motorbikes;

/// <summary>
/// Represents the BMW sport bike class.
/// </summary>
/// <param name="name">The motorbike name.</param>
/// <param name="brand">The motorbike brand.</param>
/// <param name="displacement">The motorbike displacement.</param>
/// <param name="color">The motorbike color.</param>
/// <param name="wetWeight">The motorbike wet weight.</param>
/// <param name="fuelTankCapacity">The motorbike fuel tank capacity.</param>
/// <param name="consumptionRate">The motorbike consumption rate.</param>
/// <param name="absSupport">The motorbike ABS support.</param>
internal sealed class BMWSportBike(string name,
                                   Brand brand,
                                   int displacement,
                                   Color color,
                                   int wetWeight,
                                   int fuelTankCapacity,
                                   float consumptionRate,
                                   bool absSupport) : Motorbike
{
    protected override string Name { get; } = name;
    protected override Brand Brand { get; } = brand;
    protected override int Displacement { get; } = displacement;
    protected override Color Color { get; } = color;
    protected override int WetWeight { get; } = wetWeight;
    protected override int FuelTankCapacity { get; } = fuelTankCapacity;
    protected override float ConsumptionRate { get; } = consumptionRate;
    protected override bool AbsSupport { get; } = absSupport;

    public override void PaymentMethod()
        => Console.WriteLine($"Payment Method: {Enums.PaymentMethod.DebitCard.GetDescription()}");
}
