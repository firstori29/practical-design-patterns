namespace AbstractFactory.MotorbikeFactories.Abstractions;

/// <summary>
/// Represents class motorbike factory.
/// </summary>
internal sealed class ClassicBikeFactory : MotorbikeTypeAbstractFactory
{
    protected override Motorbike? CreateMotorbike(string type)
    {
        switch (type)
        {
            case nameof(BMWClassicBike):
                return new BMWClassicBike(
                    "R18 Classic",
                    Brand.BMW,
                    900,
                    Color.Silver,
                    210,
                    23,
                    7.6f,
                    true
                );

            case nameof(DucatiClassicBike):
                return new DucatiClassicBike(
                    "Scramble Icon",
                    Brand.Ducati,
                    1000,
                    Color.Yellow,
                    202,
                    20,
                    6.4f,
                    false
                );

            case nameof(YamahaClassicBike):
                return new YamahaClassicBike(
                    "XSR900",
                    Brand.Yamaha,
                    890,
                    Color.Black,
                    189,
                    18,
                    5.5f,
                    true
                );

            default:
                Console.WriteLine($"Unknown motorbike type: {type}.");
                return null;
        }
    }
}