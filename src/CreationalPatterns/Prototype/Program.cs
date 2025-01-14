var motorBikes = new List<Motorbike>();

var classicBike = new ClassicBike { HeadlightType = "Round" };
motorBikes.Add(classicBike);

var anotherClassicBike = (ClassicBike)classicBike.Clone();
anotherClassicBike.HeadlightType = "Rectangle";
motorBikes.Add(anotherClassicBike);

var sportBike = new SportBike
{
    TopSpeed = 250
};
motorBikes.Add(sportBike);

var anotherSportBike = (SportBike)sportBike.Clone();
anotherSportBike.TopSpeed = 300;
motorBikes.Add(anotherSportBike);

var nakedBike = new NakedBike();
var anotherNakedBike = (NakedBike)nakedBike.Clone();
motorBikes.Add(anotherNakedBike);

Console.WriteLine("Motorbikes prototype.");
foreach (var motorBike in motorBikes)
    Console.WriteLine(motorBike.GetType().Name);

Console.WriteLine();

Console.WriteLine("Motorbikes prototype copy.");
var motorbikesCopy = motorBikes.Select(m => m.Clone()).ToList();
foreach (var motorBikeCpy in motorbikesCopy)
    Console.WriteLine(motorBikeCpy.GetType().Name);
