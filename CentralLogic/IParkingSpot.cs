using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralLogic;

public interface IParkingSpot
{
    public List<Vehicle> ParkedVehicles { get;}
    public int MaxSize { get;} //The total size of vehicles the spot can hold.

    public int CurrentSize { get; }
    public void Park(Vehicle vehicle);
    public Vehicle PickUp(Vehicle vehicle);
    public Vehicle PickUp(string regNum);
    public bool ContainsVehicle(Vehicle vehicle);
}
