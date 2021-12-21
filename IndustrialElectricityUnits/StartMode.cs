using Ardalis.SmartEnum;

namespace IndustrialElectricityUnits;

public class StartMode:SmartEnum<StartMode>
{
    public static readonly StartMode Dol = new("DOL", 0, "Direct Online");
    public static readonly StartMode Sd = new("SD", 1, "Star-Delta");
    public static readonly StartMode Ssd = new("SSD", 2, "Soft Start Drive");
    public static readonly StartMode Vsd = new("VSD", 3, "Variable Speed Drive");
    public string Description { get; }
    private StartMode(string name, int value,string description) : base(name, value)
    {
        Description = description;
        
    }
}