var brand = nameof(HarleyDavidson);

MotorbikeCreator? creator;

switch (brand)
{
    case nameof(Yamaha):
        creator = new YamahaCreator();
        break;

    case nameof(BMW):
        creator = new BMWCreator();
        break;

    case nameof(Honda):
        creator = new HondaCreator();
        break;

    case nameof(Ducati):
        creator = new DucatiCreator();
        break;

    case nameof(HarleyDavidson):
        creator = new HarleyDavidsonCreator();
        break;

    default:
        creator = null;
        Console.WriteLine($"Unknown motorbike brand: {brand}.");
        break;
}

creator?.MotorbikeInvoice();