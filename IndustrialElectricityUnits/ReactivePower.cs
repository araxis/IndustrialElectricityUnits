using Ardalis.GuardClauses;

namespace IndustrialElectricityUnits;

public abstract record ReactivePower
{
    private readonly double _value;

    protected ReactivePower(double value)
    {
        _value = Guard.Against.Negative(value,nameof(Value));
    }

    public double Value
    {
        get => _value;
        init => _value = Guard.Against.Negative(value, nameof(Value));
    }
    public abstract string Symbol { get; }
    public abstract VoltAmpereReactive ToVAr();
    public abstract ReactivePower FromVAr(VoltAmpereReactive value);
    
    public static ReactivePower operator ^(ReactivePower power, double pow) => power with{Value = Math.Pow(power.Value,pow)};
 
}
public sealed record VoltAmpereReactive : ReactivePower
{
    public VoltAmpereReactive(double value):base(value)
    {
        
    }

    public override string Symbol => "VA";
    public override VoltAmpereReactive ToVAr() => new(Value);
    public override VoltAmpereReactive FromVAr(VoltAmpereReactive power) => new(power.Value);

    public static implicit operator VoltAmpereReactive(double value) => new(value);
    public static implicit operator double(VoltAmpereReactive value) => value.Value;
   
}

public record KiloVoltAmpereReactive : ReactivePower
{
    public KiloVoltAmpereReactive(double value) : base(value)
    {
    }
    public override string Symbol => "kVA";
    public override VoltAmpereReactive ToVAr() => new(Value * 1000);
    public override KiloVoltAmpereReactive FromVAr(VoltAmpereReactive power) => new(power.Value / 1000);

    public static implicit operator KiloVoltAmpereReactive(double value) => new(value);
    public static implicit operator double(KiloVoltAmpereReactive value) => value.Value;
}