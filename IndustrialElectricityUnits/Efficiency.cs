using Ardalis.GuardClauses;

namespace IndustrialElectricityUnits;

public record Efficiency
{
    private readonly double _value;

    public Efficiency(double value)
    {
        _value = ValidateValue(value, nameof(value));

    }

    public double Value
    {
        get => _value;
        init => _value =  ValidateValue(value, nameof(Value));
    }

    private double ValidateValue(double value,string paramName)
    {
        return Guard.Against.OutOfRange(value, paramName, 0, 100);
    }

    public static implicit operator Efficiency(double value) => new (value);
    public static implicit operator double(Efficiency value) => value.Value;
   
}