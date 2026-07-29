using System.Text.Json.Serialization;

namespace CentralLogic;

public class ParkingHouse : IParkingHouse
{
    //fields
    private ParkingSpot[] parkingSpots;

    //Properties
    public int Size { get => parkingSpots.Length; }
    public ParkingSpot[] ParkingSpots => parkingSpots;


    //Constructors
    public ParkingHouse() : this(100)
    {
    }
    public ParkingHouse(int size)
    {
        this.parkingSpots = new ParkingSpot[size];
        for (int i = 0; i < ParkingSpots.Length; i++)
        {
            ParkingSpots[i] = new ParkingSpot();
        }
    }
    public ParkingHouse(ParkingSpot[] storedParkingSpots)
    {
        this.parkingSpots = storedParkingSpots;
    }
    [JsonConstructor]
    public ParkingHouse(int size, ParkingSpot[] ParkingSpots)
    {
        this.parkingSpots = ParkingSpots;
        Array.Resize(ref this.parkingSpots, size);
        for (int i = ParkingSpots.Length; i < size; i++)
        {
            ParkingSpots[i] = new ParkingSpot();
        }

    }

    //Methods
    public bool ContainsVehicle(Vehicle vehicle)
    {
        return Array.Exists(parkingSpots, x => x.ContainsVehicle(vehicle));
    }
    public bool ContainsVehicle(string regNum)
    {
        return Array.Exists(parkingSpots, x => x.ContainsVehicle(regNum));
    }

    public void MoveVehicle(string regNum, ParkingSpot parkingSpot)
    {
        int i = FindVehicle(regNum);
        var vehicle = PickUp(regNum);
        try
        {
            parkingSpot.Park(vehicle);
        }
        catch (Exception)
        {
            parkingSpots[i].Park(vehicle); //put back the vehicle in case the parking failed.
            throw;
        }
    }

    public void MoveVehicle(string regNum, int parkingSpotIndex)
    {
        MoveVehicle(regNum, parkingSpots[parkingSpotIndex]);
    }

    public void Park(Vehicle vehicle)
    {
        foreach (ParkingSpot parkingSpot in parkingSpots)
        {
            try
            {
                parkingSpot.Park(vehicle);
                break;
            }
            catch (Exception) { }
        }
    }

    public void Park(string regNum, string? vehicleType, List<Vehicle> vehicleTemplates)
    {
        if (!ContainsVehicle(regNum))
        {
            Vehicle vehicle;
            switch (vehicleType)
            {
                case "Car":
                    {
                        vehicle = new Car(regNum);
                        break;
                    }
                case "MC":
                    {
                        vehicle = new MC(regNum);
                        break;
                    }
                case null:
                    {
                        throw new ArgumentNullException("Ingen fordons typ valdes.");
                    }

                default:
                    Vehicle vehicleTemplate = vehicleTemplates.Find(x => vehicleType == x.KindOfVehicle)!;
                    vehicle = new BlankVehicle(regNum, vehicleType, vehicleTemplate.Size);
                    break;
            }
            bool foundParking = false;
            foreach (var parkingSpot in ParkingSpots)
            {
                try
                {
                    parkingSpot.Park(vehicle);
                    foundParking = true;
                    break;

                }
                catch (Exception)
                {
                }
            }
            if (!foundParking)
            {
                throw new InvalidOperationException($"{regNum} får inte plats på någon plats alls");
            }

        }
        else { throw new ArgumentException("Du kan inte parkera flera fordon med samma registreringsnummer."); }
    }
    public Vehicle PickUp(string regNum)
    {
        int i = FindVehicle(regNum);
        return parkingSpots[i].PickUp(regNum);
    }
    public int FindVehicle(string regNum)
    {
        int index = Array.FindIndex(parkingSpots, x => x.ContainsVehicle(regNum));
        if (index != -1)
        {
            return index;
        }
        else
        {
            throw new ArgumentException($"{regNum} finns inte parkerad här.");
        }
    }
    public Vehicle GetVehicle(string regNum)
    {
        int index = FindVehicle(regNum);
        return parkingSpots[index].GetVehicle(regNum);
    }
}
