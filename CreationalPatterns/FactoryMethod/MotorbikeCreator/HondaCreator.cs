namespace FactoryMethod.MotorbikeCreator;

/// <summary>
/// Represents the Honda motorbike creator.
/// </summary>
internal sealed class HondaCreator : Base.MotorbikeCreator
{
    protected override Motorbike CreateMotorbike()
    {
        return new Honda(
            "CB1000RR-R FireBlade",
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