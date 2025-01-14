MotorbikeTypeAbstractFactory classicBikeCreator = new ClassicBikeFactory();
classicBikeCreator.MotorbikeInformation(nameof(BmwClassicBike));

MotorbikeTypeAbstractFactory sportBikeCreator = new SportBikeFactory();
sportBikeCreator.MotorbikeInformation(nameof(DucatiSportBike));

MotorbikeTypeAbstractFactory nakedBikeCreator = new NakedBikeFactory();
nakedBikeCreator.MotorbikeInformation(nameof(YamahaNakedBike));
