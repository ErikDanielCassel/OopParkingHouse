using CentralLogic;
using System.Text.Json;

namespace DataAccess;

public static class Initalizer
{
    const string _path = "../../../../";
    const string _ConfigurationDataFile = _path + "ConfigurationData.json";
    const string _ParkingHouseFile = _path + "ParkingHouse.json";
    const string _CzkPerHoursFile = _path + "CzkPerHours.json";
    public static void CreateFiles()
    {
        WriteStandardParkingHouse();
        WriteStandardCzkPerHours();
        WriteStandardConfigurationData();
    }
    public static ParkingHouse StartUp()
    {
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
        return json.VehicleList;
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
    public static void WriteStandardParkingHouse()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(new ParkingHouse(ReadParkingHouseSize()), options);
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
        string jsonString = JsonSerializer.Serialize(new ConfigurationData(100, new List<Vehicle> { new Car("abc123"), new MC("abc123") }), options);
        File.WriteAllText(_ConfigurationDataFile, jsonString);
    }
}
