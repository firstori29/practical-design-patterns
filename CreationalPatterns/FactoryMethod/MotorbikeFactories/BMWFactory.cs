namespace FactoryMethod.MotorbikeFactories;

/// <summary>
/// Represents the BMW motorbike factory.
/// </summary>
internal sealed class BMWFactory : MotorbikeFactory
{
    protected override Motorbike CreateMotorbike()
    {
        return new BMW(
            "BMW basic",
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