// Create the control tower (mediator)
var controlTower = new AirTrafficControlMediator();

// Create aircraft (colleagues) that register with the control tower
Aircraft biplane = new Biplane("Flight B253", controlTower);
Aircraft helicopter = new Helicopter("Flight H639", controlTower);
Aircraft passengerAirliner = new PassengerAirliner("Flight P977", controlTower);

// Aircraft request landing
helicopter.RequestLanding();
biplane.RequestLanding();
helicopter.RequestLanding();
passengerAirliner.RequestLanding();
