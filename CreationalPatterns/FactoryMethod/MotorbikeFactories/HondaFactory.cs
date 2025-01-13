namespace FactoryMethod.MotorbikeFactories;

/// <summary>
/// Represents the Honda motorbike factory.
/// </summary>
internal sealed class HondaFactory : MotorbikeFactory
{
    protected override Motorbike CreateMotorbike()
    {
        return new Honda(
            "Honda basic",
            Brand.Honda,
            1000,
            Color.Red,
            200,
            19,
            5.0f,
            true
        );
    }
}