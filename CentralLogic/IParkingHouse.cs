namespace CentralLogic;

public interface IParkingHouse
{
    ParkingSpot[] ParkingSpots { get; } //TODO Check if it needs to have init or set.
    int Size { get; }
    void Park(Vehicle vehicle);
    void Park(string regNum, string? vehicleType, List<Vehicle> vehicleTemplates); //TODO: regNum kan behöva bli en egen klass/struct för att hantera set funktionen. You need to find all regNum and RegNum instances to fix this.
    public Vehicle PickUp(string regNum); // Pick up a vehicle and pay for the time.
    public bool ContainsVehicle(Vehicle vehicle);
    public void MoveVehicle(string regNum, int parkingSpotIndex); //Move vehicle to a different spot.
    public void MoveVehicle(string regNum, ParkingSpot parkingSpot); //Move vehicle to a different spot.
    public int FindVehicle(string regNum); //Returns the index of the spot the vehicle is at
    public Vehicle GetVehicle(string regNum); //gets the vehicle object but doesn't remove it.
}