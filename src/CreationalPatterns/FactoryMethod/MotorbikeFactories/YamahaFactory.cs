namespace FactoryMethod.MotorbikeFactories;

/// <summary>
/// Represents the Yamaha motorbike factory.
/// </summary>
internal sealed class YamahaFactory : MotorbikeFactory
{
    protected override Motorbike CreateMotorbike()
    {
        return new Yamaha(
            "Yamaha basic",
            Brand.Yamaha,
            890,
            Color.Blue,
            180,
            15,
            2.5f,
            false);
    }
}
