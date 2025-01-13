namespace FactoryMethod.MotorbikeFactories;

/// <summary>
/// Represents the HarleyDavidson motorbike factory.
/// </summary>
internal sealed class HarleyDavidsonFactory : MotorbikeFactory
{
    protected override Motorbike CreateMotorbike()
    {
        return new HarleyDavidson(
            "HD basic",
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