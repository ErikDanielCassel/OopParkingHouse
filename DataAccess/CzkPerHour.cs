using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess;

public record class CzkPerHour
{
    public int Car {get; init; }
    public int MC { get; init; }
    public int FreeMinuits { get; init; }
}