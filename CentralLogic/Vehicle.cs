using System.Text.Json.Serialization;

namespace CentralLogic;

[JsonDerivedType(typeof(Car), "Car")]
[JsonDerivedType(typeof(MC), "MC")]
[JsonDerivedType(typeof(BlankVehicle), "BlankVehicle")]
public abstract class Vehicle : IVehicle
{
    //The base for all vehicle types and the type parkingspots will have in their lists.
    private string? _regNum;
    public string RegNum
    {
        get => _regNum!;
        private set
        {
            //TODO: Check if we need to check the registration number anywhere else and if that is the case create a new registration method.
            bool correctRegistration = value.Length == 6 && /*checks if that there is no more text after the RegNumistration number*/char.IsAsciiLetter(value[0]) && char.IsAsciiLetter(value[1]) && char.IsAsciiLetter(value[2]) && /*Check if first 3 are letters*/char.IsNumber(value[3]) && char.IsNumber(value[4]) && char.IsNumber(value[5]); /*Checks if last 3 are numbers*/
            if (correctRegistration)
            {
                _regNum = value;
            }
            else
            {
                throw new FormatException("Inkorrekt registreringsnummer format.\nDet ska var \"abc123\"");
            }
        }
    }
    public abstract string KindOfVehicle { get; }
    public abstract int Size { get; }
    public DateTime TimeParked { get; }

    protected Vehicle(string regNum)
    {
        this.RegNum = regNum;
        this.TimeParked = DateTime.Now;
    }
}
