using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralLogic;

public class MC : Vehicle
{
    public MC(string RegNum) : base(RegNum)
    {
    }

    public override string KindOfVehicle => "MC";

    public override int Size => 2;
}
