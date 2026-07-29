using CentralLogic;
using DataAccess;

ParkingSpot parkingSpot = new ParkingSpot();

ParkingSpot[] parkingHouse = new ParkingSpot[20];
for (int i = 0; i < parkingHouse.Length; i++)
{
    parkingHouse[i] = new ParkingSpot();
}
Initalizer.CreateFiles();