namespace CentralLogic;

public interface IParkingHouse
{
    ParkingSpot[] ParkingSpots { get; } //TODO Check if it needs to have init or set.
    void Park(Vehicle vehicle);
    void Park(string regNum); //TODO: regNum kan behöva bli en egen klass/struct för att hantera set funktionen. You need to find all regNum and RegNum instances to fix this.
    public Vehicle PickUp(Vehicle vehicle); // Pick up a vehicle and pay for the time.
    public Vehicle PickUp(string regNum); // Pick up a vehicle and pay for the time.
    public bool ContainsVehicle(Vehicle vehicle);
    public ParkingSpot MoveVehicle(Vehicle vehicle, ParkingSpot parkingSpot); //Move vehicle to a different spot.
    public ParkingSpot MoveVehicle(string regNum, ParkingSpot parkingSpot); //Move vehicle to a different spot.
    public ParkingSpot MoveVehicle(Vehicle vehicle, int parkingSpotIndex); //Move vehicle to a different spot.
    public ParkingSpot MoveVehicle(string regNum, int parkingSpotIndex); //Move vehicle to a different spot.
}