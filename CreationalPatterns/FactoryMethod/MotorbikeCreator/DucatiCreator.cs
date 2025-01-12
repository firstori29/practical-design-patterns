namespace FactoryMethod.MotorbikeCreator;

/// <summary>
/// Represents the Ducati motorbike creator.
/// </summary>
internal sealed class DucatiCreator : Base.MotorbikeCreator
{
    protected override Motorbike CreateMotorbike()
    {
        return new Ducati(
            "Panigale V4s",
            Brand.Ducati,
            999,
            Color.Red,
            178,
            13,
            4.7f,
            true
        );
    }
}