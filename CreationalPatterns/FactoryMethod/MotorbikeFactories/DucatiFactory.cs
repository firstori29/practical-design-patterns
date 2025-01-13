namespace FactoryMethod.MotorbikeFactories;

/// <summary>
/// Represents the Ducati motorbike factory.
/// </summary>
internal sealed class DucatiFactory : MotorbikeFactory
{
    protected override Motorbike CreateMotorbike()
    {
        return new Ducati(
            "Ducati basic",
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