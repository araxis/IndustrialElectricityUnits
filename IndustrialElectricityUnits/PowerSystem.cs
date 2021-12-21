using Ardalis.SmartEnum;

namespace IndustrialElectricityUnits;

public sealed class PowerSystem:SmartEnum<PowerSystem>
{
   // SinglePhase,ThreePhase
   public static readonly PowerSystem SinglePhase = new("Single Phase", 0);
   public static readonly PowerSystem TwoPhase = new("Two Phase", 1);
   public static readonly PowerSystem ThreePhase = new("Three Phase", 2);

   private PowerSystem(string name, int value) : base(name, value)
    {
    }

  
}