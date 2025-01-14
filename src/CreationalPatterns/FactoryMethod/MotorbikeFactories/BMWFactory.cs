namespace FactoryMethod.MotorbikeFactories;

/// <summary>
/// Represents the BMW motorbike factory.
/// </summary>
internal sealed class BmwFactory : MotorbikeFactory
{
    protected override Motorbike CreateMotorbike()
    {
        return new Bmw(
            "BMW basic",
            Brand.BMW,
            1200,
            Color.Gray,
            201,
            23,
            5.1f,
            true);
    }
}
