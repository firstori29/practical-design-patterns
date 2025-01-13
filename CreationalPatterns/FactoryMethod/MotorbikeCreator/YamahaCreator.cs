namespace FactoryMethod.MotorbikeCreator;

/// <summary>
/// Represents the Yamaha motorbike creator.
/// </summary>
internal sealed class YamahaCreator : Base.MotorbikeCreator
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
            false
        );
    }
}