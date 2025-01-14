namespace AbstractFactory.MotorbikeFactories.Abstractions;

/// <summary>
/// Represents class motorbike factory.
/// </summary>
internal sealed class SportBikeFactory : MotorbikeTypeAbstractFactory
{
    protected override Motorbike? CreateMotorbike(string type)
    {
        switch (type)
        {
            case nameof(BmwSportBike):
                return new BmwSportBike(
                    "S1000RR",
                    Brand.BMW,
                    1100,
                    Color.Blue,
                    199,
                    21,
                    8.0f,
                    true);

            case nameof(DucatiSportBike):
                return new DucatiSportBike(
                    "Panigale V4s",
                    Brand.Ducati,
                    998,
                    Color.Yellow,
                    180,
                    22,
                    9.4f,
                    true);

            case nameof(YamahaSportBike):
                return new YamahaSportBike(
                    "R1",
                    Brand.Yamaha,
                    998,
                    Color.Black,
                    185,
                    19,
                    8.5f,
                    false);

            default:
                Console.WriteLine($"Unknown motorbike type: {type}.");

                return null;
        }
    }
}
