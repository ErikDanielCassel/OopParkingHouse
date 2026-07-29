using System.Text.Json.Serialization;

namespace CentralLogic;

public class ParkingSpot : IParkingSpot
{
    public List<Vehicle> ParkedVehicles { get; }
    public int MaxSize { get; }
    public int CurrentSize { get { return ParkedVehicles.Sum(vehicle => vehicle.Size); } }

    [JsonConstructor]
    public ParkingSpot(int MaxSize, List<Vehicle> Parkedvehicles)
    {
        this.MaxSize = MaxSize;
        ParkedVehicles = Parkedvehicles;
    }
    public ParkingSpot(int size) : this(size, [])
    {
    }
    public ParkingSpot() : this(4, [])
    {

    }

    public void Park(Vehicle vehicle)
    {
        if (CurrentSize + vehicle.Size <= MaxSize)
        {
            ParkedVehicles.Add(vehicle);
        }
        else
        {
            throw new InvalidOperationException("The Parking spot can't fit that vehicle");
        }
    }
    public Vehicle PickUp(Vehicle vehicle)
    {
        //Removes the vehicle from the list and returns it
        bool success = ParkedVehicles.Remove(vehicle);
        if (success)
        {
            return vehicle;
        }
        else
        {
            throw new InvalidOperationException("That vehicle wasn't parked at this spot.");
        }
    }
    public Vehicle PickUp(string regNum)
    {
        //Removes the vehicle from the list and returns it
        var vehicle = GetVehicle(regNum);
        ParkedVehicles.Remove(vehicle);
        return vehicle;
    }
    public bool ContainsVehicle(Vehicle vehicle)
    {
        //Checks if the vehicle is parked in this spot.
        return ParkedVehicles.Contains(vehicle);
    }
    public bool ContainsVehicle(string regNum)
    {
        //Checks if the vehicle is parked in this spot.
        return ParkedVehicles.Exists(vehicle => vehicle.RegNum == regNum);
    }
    public Vehicle GetVehicle(string regNum)
    {
        try
        {
            Vehicle vehicle = ParkedVehicles.First(vehicle => vehicle.RegNum == regNum);
            return vehicle;
        }
        catch (InvalidOperationException ex)
        {
            throw new InvalidOperationException("Can inte hitta fordonet", ex);
        }
    }
}
