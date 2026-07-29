using CentralLogic;
using System.Text.Json;

namespace DataAccess;

public static class Save
{
    const string _path = "../../../../";
    const string _ConfigurationDataFile = _path + "ConfigurationData.json";
    const string _ParkingHouseFile = _path + "ParkingHouse.json";
    const string _CzkPerHoursFile = _path + "CzkPerHours.json";
    public static void ParkingHouse(ParkingHouse parkingHouse)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(parkingHouse, options);
        File.WriteAllText(_ParkingHouseFile, jsonString);
    }
    public static void CzkPerHour(CzkPerHour czkPerHour)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(czkPerHour, options);
        File.WriteAllText(_CzkPerHoursFile, jsonString);
    }
}
