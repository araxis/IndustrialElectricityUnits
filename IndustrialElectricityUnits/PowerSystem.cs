using Ardalis.SmartEnum;

namespace IndustrialElectricityUnits;

public sealed class PowerSystem:SmartEnum<PowerSystem>
{
   // SinglePhase,ThreePhase
   public static readonly PowerSystem SinglePhase = new("Single Phase", 0);
   public static readonly PowerSystem ThreePhase = new("Three Phase", 1);

   private PowerSystem(string name, int value) : base(name, value)
   {
   }

  
}