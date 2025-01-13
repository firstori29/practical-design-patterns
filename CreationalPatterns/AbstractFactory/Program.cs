MotorbikeTypeAbstractFactory classicBikeCreator = new ClassicBikeCreator();
classicBikeCreator.MotorbikeInformation(nameof(BMWClassicBike));

MotorbikeTypeAbstractFactory sportBikeCreator = new SportBikeCreator();
sportBikeCreator.MotorbikeInformation(nameof(DucatiSportBike));

MotorbikeTypeAbstractFactory nakedBikeCreator = new NakedBikeCreator();
nakedBikeCreator.MotorbikeInformation(nameof(YamahaNakedBike));