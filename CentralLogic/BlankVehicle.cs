using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralLogic;

public class BlankVehicle : Vehicle
{
    //Take in paramaters for all value to allow for any kind of vehicle to be created from KonfigurationData.cs.
    public override string KindOfVehicle { get; }
    public override int Size { get; }
    public BlankVehicle(string regNum, string kindOfVehicle, int size): base(regNum)
    {
        KindOfVehicle = kindOfVehicle;
        Size = size;
    }
}
