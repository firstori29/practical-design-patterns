namespace FactoryMethod.MotorbikeCreator.Base;

/// <summary>
/// Represents the motorbike creator.
/// </summary>
internal abstract class MotorbikeCreator
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Motorbike"/> class.
    /// </summary>
    /// <returns>A new instance of the <see cref="Motorbike"/> class.</returns>
    protected abstract Motorbike CreateMotorbike();

    /// <summary>
    /// The motorbike sale invoice.
    /// </summary>
    /// <returns>The result of sale.</returns>
    public void MotorbikeInvoice()
    {
        var motorbike = CreateMotorbike();

        motorbike.MotorBikeSpecs();

        motorbike.PaymentMethod();

        motorbike.ShippingMethod();
    }
}