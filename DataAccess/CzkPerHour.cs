namespace DataAccess;

public record class CzkPerHour
{
    public int Car { get; init; }
    public int MC { get; init; }
    public int FreeMinuits { get; init; }
}