using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralLogic;

public class ParkingHouse : IParkingHouse
{
    //fields
    private ParkingSpot[] parkingSpots;

    //Properties
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
    public ParkingHouse(int size, ParkingSpot[] storedParkingSpots)
    {
        this.parkingSpots = storedParkingSpots;
        Array.Resize(ref this.parkingSpots, size);

    }

    //Methods
    public bool ContainsVehicle(Vehicle vehicle)
    {
        throw new NotImplementedException();
    }

    public ParkingSpot MoveVehicle(Vehicle vehicle, ParkingSpot parkingSpot)
    {
        throw new NotImplementedException();
    }

    public ParkingSpot MoveVehicle(string regNum, ParkingSpot parkingSpot)
    {
        throw new NotImplementedException();
    }

    public ParkingSpot MoveVehicle(Vehicle vehicle, int parkingSpotIndex)
    {
        throw new NotImplementedException();
    }

    public ParkingSpot MoveVehicle(string regNum, int parkingSpotIndex)
    {
        throw new NotImplementedException();
    }

    public void Park(Vehicle vehicle)
    {
        throw new NotImplementedException();
    }

    public void Park(string regNum)
    {
        throw new NotImplementedException();
    }

    public Vehicle PickUp(Vehicle vehicle)
    {
        throw new NotImplementedException();
    }

    public Vehicle PickUp(string regNum)
    {
        throw new NotImplementedException();
    }
}
