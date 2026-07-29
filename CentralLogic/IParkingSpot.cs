namespace CentralLogic;

public interface IParkingSpot
{
    public List<Vehicle> ParkedVehicles { get; }
    public int MaxSize { get; } //The total size of vehicles the spot can hold.

    public int CurrentSize { get; }
    public void Park(Vehicle vehicle);
    public Vehicle PickUp(Vehicle vehicle);
    public Vehicle PickUp(string regNum);
    public bool ContainsVehicle(Vehicle vehicle);
    public Vehicle GetVehicle(string regNum); //Gets the object but doesn't remove it.
}
