var builder = new MechanicalKeyboardBuilder();

var director = new Director(builder);

// Build mechanical keyboard with delegate to the director.
Console.WriteLine("========== BUILDER PATTERN ==========\n");
Console.WriteLine("Build STANDARD mechanical keyboard components:");
director.BuildStandardMechanicalKeyboard();
Console.WriteLine(builder.GetResult().ToString());

Console.WriteLine("Build PREMIUM mechanical keyboard components: ");
director.BuildPremiumMechanicalKeyboard();
Console.WriteLine(builder.GetResult().ToString());

// Customers directly direct mechanical keyboard processes
Console.WriteLine("Build CUSTOM mechanical keyboard components: ");
builder.SetCase(new Case("CSE192", "Recycled PC"));
builder.SetLayout(new Layout("LAY315", "Ergonomics"));
Console.WriteLine(builder.GetResult().ToString());
Console.WriteLine("\t... and so on.");