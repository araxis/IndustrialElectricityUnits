using Ardalis.GuardClauses;

namespace IndustrialElectricityUnits;

public record Voltage
{
    private readonly double _value;

    public Voltage(double value)
    {
        _value = ValueValidation(value,nameof(value));
    }

  

    public double Value
    {
        get => _value;
        init => _value =  ValueValidation(value,nameof(Value));
    }

    public static implicit operator Voltage(double value) => new(value);
    public static implicit operator double(Voltage value) => value.Value;

    private double ValueValidation(double value,string paramName)
    {
        return Guard.Against.NegativeOrZero(value,paramName);
    }
   

}


