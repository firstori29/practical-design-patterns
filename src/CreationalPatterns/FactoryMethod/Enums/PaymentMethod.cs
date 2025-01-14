namespace FactoryMethod.Enums;

/// <summary>
/// The payment methods.
/// </summary>
internal enum PaymentMethod
{
    [Description("Internet banking.")] InternetBanking,
    [Description("Credit card.")] CreditCard,
    [Description("Debit card.")] DebitCard,
    Cash
}
