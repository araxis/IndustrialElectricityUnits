using Ardalis.SmartEnum;

namespace IndustrialElectricityUnits;

public class StartMode:SmartEnum<StartMode>
{
    public static readonly StartMode Dol = new("DOL", 1, "Direct Online");
    public static readonly StartMode Sd = new("SD", 2, "Star-Delta");
    public static readonly StartMode Ssd = new("DOL", 3, "Soft Start Drive");
    public static readonly StartMode Vsd = new("DOL", 4, "Variable Speed Drive");
    public string Description { get; }
    private StartMode(string name, int value,string description) : base(name, value)
    {
        Description = description;
    }
}