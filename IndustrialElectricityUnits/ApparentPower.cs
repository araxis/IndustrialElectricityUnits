using Ardalis.GuardClauses;

namespace IndustrialElectricityUnits;

public abstract record ApparentPower
{
    private readonly double _value;

    protected ApparentPower(double value)
    {
        _value = Guard.Against.Negative(value,nameof(Value));
    }

    public double Value
    {
        get => _value;
        init => _value = Guard.Against.Negative(value, nameof(Value));
    }
    public abstract string Symbol { get; }
    public abstract VoltAmpere ToVA();
    public abstract ApparentPower FromVA(VoltAmpere value);

    public static ApparentPower operator ^(ApparentPower power, double pow) => power with{Value = Math.Pow(power.Value,pow)};
    
    
 
}
public sealed record VoltAmpere : ApparentPower
{
    public VoltAmpere(double value):base(value)
    {
        
    }

    public override string Symbol => "VA";
    public override VoltAmpere ToVA() => new(Value);
    public override VoltAmpere FromVA(VoltAmpere power) => new(power.Value);

    public static implicit operator VoltAmpere(double value) => new(value);
    public static implicit operator double(VoltAmpere value) => value.Value;
}

public record KiloVoltAmpere : ApparentPower
{
    public KiloVoltAmpere(double value) : base(value)
    {
    }
    public override string Symbol => "kVA";
    public override VoltAmpere ToVA() => new(Value * 1000);
    public override KiloVoltAmpere FromVA(VoltAmpere power) => new(power.Value / 1000);

    public static implicit operator KiloVoltAmpere(double value) => new(value);
    public static implicit operator double(KiloVoltAmpere value) => value.Value;
}