namespace AbstractFactory.MotorbikeFactories.Abstractions.Base;

/// <summary>
/// Represents the motorbike type abstract factory.
/// </summary>
internal abstract class MotorbikeTypeAbstractFactory
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Motorbike"/> class.
    /// </summary>
    /// <param name="type">The motorbike type.</param>
    /// <returns>A new instance of the <see cref="Motorbike"/> class.</returns>
    protected abstract Motorbike? CreateMotorbike(string type);

    /// <summary>
    /// The motorbike information.
    /// </summary>
    /// <returns>The motorbike information.</returns>
    public void MotorbikeInformation(string type)
    {
        var motorbike = CreateMotorbike(type);

        if (motorbike is null) return;

        motorbike.MotorBikeSpecs();

        motorbike.PaymentMethod();

        motorbike.ShippingMethod();
    }
}