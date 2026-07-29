using CentralLogic;

namespace DataAccess;

public class ConfigurationData
{
    public int NumberOfParkingSpots { get; }
    public List<Vehicle> VehicleList { get; }
    public ConfigurationData(int NumberOfParkingSpots, List<Vehicle> VehicleList)
    {
        this.NumberOfParkingSpots = NumberOfParkingSpots;
        this.VehicleList = VehicleList;
    }
}