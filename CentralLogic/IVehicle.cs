using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralLogic;

public interface IVehicle
{
    public string RegNum { get; }
    public string KindOfVehicle { get; } //Might not be needed as the type itself will be named after what vehicle it is. Also might make it harder and more confusing to add new vehicle types
    public int Size {  get; }
    public DateTime TimeParked { get;}

}
