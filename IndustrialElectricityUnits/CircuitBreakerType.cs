using Ardalis.SmartEnum;

namespace IndustrialElectricityUnits;

public sealed class CircuitBreakerType:SmartEnum<CircuitBreakerType> {
 
   public string Description { get; }
   public static readonly CircuitBreakerType Tmb = new("Tmb", 0,"Thermal Magnetic Breaker");
   public static readonly CircuitBreakerType Mccb = new("MCCB", 1,"Molded Case Circuit Breaker");
   public static readonly CircuitBreakerType Acb = new("ACB", 2,"Molded Case Circuit Breaker");
   public static readonly CircuitBreakerType Fuse = new("FS", 3,"Fuse");

    private CircuitBreakerType(string name, int value, string description) : base(name, value)
    {
        Description = description;
    }
}