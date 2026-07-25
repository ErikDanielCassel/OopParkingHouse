using CentralLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess;

public record class ConfigurationData
{
    public int NumberOfParkingSpots { get; } = 100;
    public List<Vehicle> vehicleList { get; } = new List<Vehicle> {new Car("ABC123"), new MC("ABC123"), new BlankVehicle("ABC123", "Bus", 10)}; //TODO: Remove bus
}