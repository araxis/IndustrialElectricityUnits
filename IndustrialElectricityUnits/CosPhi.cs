using Ardalis.GuardClauses;

namespace IndustrialElectricityUnits;

public record CosPhi
{
    private readonly double _value;

    public CosPhi(double value)
    {
        Value = ValidateValue(value, nameof(value));
    }

    public double Value
    {
        get => _value;
        init => _value = ValidateValue(value,nameof(Value));
    }

    public double Phi => Math.Acos(_value);
    public double SinPhi => Math.Sin(Phi);
    public double TanPhi => Math.Tan(Phi);

    private double ValidateValue(double value,string paramName)
    {
       return Guard.Against.OutOfRange(value, paramName, 0, 1);
    }

    public static implicit operator CosPhi(double value) => new (value);
    public static implicit operator double(CosPhi value) => value.Value;
    public static CosPhi operator -(CosPhi left, CosPhi right) => new(left.Value - right.Value);
}