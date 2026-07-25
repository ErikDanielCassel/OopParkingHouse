using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using CentralLogic;

namespace DataAccess;

public static class Initalizer
{
    const string _path = "../../../../";
    const string _ConfigurationDataFile = _path + "ConfigurationData.json";
    const string _ParkingHouseFile = _path + "ParkingHouseSize.json";
    const string _CzkPerHoursFile = _path + "CzkPerHours.json";
    public static void CreateFiles()
    {
        WriteStandardParkingHouse();
        WriteStandardCzkPerHours();
        WriteStandardConfigurationData();
    }
    public static ParkingHouse StartUp()
    {
        //TODO: Add Vehicle types from file and make them options on the gui.
        return new ParkingHouse(ReadParkingHouseSize(), ReadParkingHouse().ParkingSpots);
    }
    private static ConfigurationData ReadConfigurationData()
    {
        if (!File.Exists(_ConfigurationDataFile))
        {
            WriteStandardConfigurationData();
        }
        string jsonString = File.ReadAllText(_ConfigurationDataFile);
        return JsonSerializer.Deserialize<ConfigurationData>(jsonString)!;

    }
    public static int ReadParkingHouseSize()
    {
        var json = ReadConfigurationData();
        return json.NumberOfParkingSpots;
    }
    public static List<Vehicle> ReadVehicleConfigurationData()
    {
        var json = ReadConfigurationData();
        return json.vehicleList;
    }
    public static ParkingHouse ReadParkingHouse()
    {
        if (!File.Exists(_ParkingHouseFile))
        {
            WriteStandardParkingHouse();
        }
        string jsonString = File.ReadAllText(_ParkingHouseFile);
        return JsonSerializer.Deserialize<ParkingHouse>(jsonString)!;
    }
    public static CzkPerHour ReadCzkPerHours()
    {
        if (!File.Exists(_CzkPerHoursFile))
        {
            WriteStandardParkingHouse();
        }
        string jsonString = File.ReadAllText(_CzkPerHoursFile);
        return JsonSerializer.Deserialize<CzkPerHour>(jsonString)!;
    }

    public static void CreateVehicleConfiguration(VehicleConfigurationData vehicleConfigurationData)
    {
        //TODO: Vehicle type stuff connected to startUp.
    }
    public static void WriteStandardParkingHouse()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(new ParkingHouse(), options);
        File.WriteAllText(_ParkingHouseFile, jsonString);
    }
    public static void WriteStandardCzkPerHours()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(new CzkPerHour() { Car = 20, MC = 10, FreeMinuits = 10 }, options);
        File.WriteAllText(_CzkPerHoursFile, jsonString);
    }
    public static void WriteStandardConfigurationData()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(new ConfigurationData(), options);
        File.WriteAllText(_ConfigurationDataFile, jsonString);
    }
}
