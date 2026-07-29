using System.Text.Json.Serialization;

namespace CentralLogic;

public class Car : Vehicle
{
    public Car(string RegNum) : base(RegNum)
    {
    }
    [JsonConstructor]
    public Car(string RegNum, DateTime TimeParked) : base(RegNum, TimeParked)
    {
    }

    public override string KindOfVehicle => "Car";

    public override int Size => 4;
}
