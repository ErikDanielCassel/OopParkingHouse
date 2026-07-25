using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralLogic;

public class Car : Vehicle
{
    public Car(string RegNum) : base(RegNum)
    {
    }

    public override string KindOfVehicle => "Car";

    public override int Size => 4;
}
