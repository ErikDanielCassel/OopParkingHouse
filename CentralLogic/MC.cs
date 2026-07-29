using System.Text.Json.Serialization;

namespace CentralLogic;

public class MC : Vehicle
{
    public MC(string RegNum) : base(RegNum)
    {
    }
    [JsonConstructor]
    public MC(string RegNum, DateTime TimeParked) : base(RegNum, TimeParked)
    {
    }

    public override string KindOfVehicle => "MC";

    public override int Size => 2;
}
