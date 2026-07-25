using CentralLogic;

namespace DataAccess;

public record class VehicleConfigurationData
{
    public BlankVehicle BlankVehicle { get; } = new BlankVehicle("", "KindOfVehicle", 0);

    public Car Car { get; } = new Car("");
    public MC Mc { get; } = new MC("");
}
