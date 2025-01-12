namespace FactoryMethod.MotorbikeCreator;

/// <summary>
/// Represents the BMW motorbike creator.
/// </summary>
internal sealed class BMWCreator : Base.MotorbikeCreator
{
    protected override Motorbike CreateMotorbike()
    {
        return new BMW(
            "GS 1250",
            Brand.BMW,
            1200,
            Color.Gray,
            201,
            23,
            5.1f,
            true
        );
    }
}