namespace AbstractFactory.MotorbikeFactories.Abstractions;

/// <summary>
/// Represents class motorbike factory.
/// </summary>
internal sealed class NakedBikeFactory : MotorbikeTypeAbstractFactory
{
    protected override Motorbike? CreateMotorbike(string type)
    {
        switch (type)
        {
            case nameof(BmwNakedBike):
                return new BmwNakedBike(
                    "S1000R",
                    Brand.BMW,
                    1100,
                    Color.Gray,
                    200,
                    19,
                    8.9f,
                    true);

            case nameof(DucatiNakedBike):
                return new DucatiNakedBike(
                    "Monster 795",
                    Brand.Ducati,
                    801,
                    Color.Red,
                    170,
                    18,
                    8.5f,
                    true);

            case nameof(YamahaNakedBike):
                return new YamahaNakedBike(
                    "MT-10",
                    Brand.Yamaha,
                    999,
                    Color.Blue,
                    210,
                    18,
                    5.3f,
                    true);

            default:
                Console.WriteLine($"Unknown motorbike type: {type}.");

                return null;
        }
    }
}
