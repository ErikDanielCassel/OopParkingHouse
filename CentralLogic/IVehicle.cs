using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralLogic;

internal interface IVehicle
{
    public string REgNum { get; init; }
    public VehicleType KindOfVehicle { get; init; } //Might not be needed as the type itself will be named after what vehicle it is. Also might make it harder and more confusing to add new

}
