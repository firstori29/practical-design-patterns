namespace FactoryMethod.MotorbikeCreator;

/// <summary>
/// Represents the HarleyDavidson motorbike creator.
/// </summary>
internal sealed class HarleyDavidsonCreator : Base.MotorbikeCreator
{
    protected override Motorbike CreateMotorbike()
    {
        return new HarleyDavidson(
            "HD Fat Boy 114",
            Brand.HarleyDavidson,
            1500,
            Color.Black,
            250,
            20,
            6.8f,
            true
        );
    }
}