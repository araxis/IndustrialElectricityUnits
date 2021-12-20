using Ardalis.GuardClauses;

namespace IndustrialElectricityUnits;

public abstract record Power
{
    private readonly double _value;

    protected Power(double value)
    {
        _value = Guard.Against.Negative(value,nameof(Value));
    }

    public double Value
    {
        get => _value;
        init => _value = Guard.Against.Negative(value, nameof(Value));
    }
    public abstract string Unit { get; }
    public abstract Watt ToWatt();
    public abstract Power From(Watt value);
    
    public static bool operator > (Power left, Power right) => left.ToWatt().Value > right.ToWatt().Value;
    public static bool operator >= (Power left, Power right) => left.ToWatt().Value >= right.ToWatt().Value;
    public static bool operator < (Power left, Power right) => left.ToWatt().Value < right.ToWatt().Value;
    public static bool operator <= (Power left, Power right) => left.ToWatt().Value <= right.ToWatt().Value;
    public static Watt operator + (Power left, Power right) => new(left.ToWatt().Value + right.ToWatt().Value);
    
 
}
public sealed record Watt : Power
{
    public Watt(double value):base(value)
    {
        
    }

    public override string Unit => "w";
    public override Watt ToWatt() => new(Value);
    public override Watt From(Watt power) => new(power.Value);

    public static implicit operator Watt(double value) => new(value);
    public static implicit operator double(Watt value) => value.Value;
  
}

public record KiloWatt : Power
{
    public KiloWatt(double value) : base(value)
    {
    }
    public override string Unit => "kW";
    public override Watt ToWatt() => new(Value * 1000);
    public override KiloWatt From(Watt power) => new(power.Value / 1000);

    public static implicit operator KiloWatt(double value) => new(value);
 
}

public record HorsePower : Power
{
    public HorsePower(double value) : base(value)
    {
    }

    public override string Unit => "hp";
    public override Watt ToWatt() => new(Value * 745.7);

    public override HorsePower From(Watt power) => new(power.Value / 745.7);

    public static implicit operator HorsePower(double value) => new(value);


}






