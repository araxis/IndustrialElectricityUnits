using Ardalis.GuardClauses;

namespace IndustrialElectricityUnits;

public abstract record  Current
{
    private readonly double _value;

    protected Current(double value)
    {
        _value = Guard.Against.Negative(value,nameof(Value));
    }

    public double Value
    {
        get => _value;
        init => _value =   Guard.Against.Negative(value,nameof(Value));
    }

    public abstract string Unit { get; }

    public abstract Ampere ToAmpere();
    public abstract Current From(Ampere value);

    public static bool operator > (Current left, Current right) => left.ToAmpere().Value > right.ToAmpere().Value;
    public static bool operator >= (Current left, Current right) => left.ToAmpere().Value >= right.ToAmpere().Value;
    public static bool operator < (Current left, Current right) => left.ToAmpere().Value < right.ToAmpere().Value;
    public static bool operator <= (Current left, Current right) => left.ToAmpere().Value <= right.ToAmpere().Value;
    public static Ampere operator + (Current left, Current right) => new(left.ToAmpere().Value + right.ToAmpere().Value);
    public static Current operator / (Current current, double div) => current with { Value = current.Value / div };
    public static Current operator * (Current current, double div) => current with { Value = current.Value * div };

 

}

public sealed record Ampere : Current
{
    public Ampere(double value) : base(value)
    {
    }


    public override string Unit => "A";
    public override Ampere ToAmpere()=> new(Value);
    public override Ampere From(Ampere value) => new(value.Value);

    public static implicit operator Ampere(double value) => new(value);
    public static implicit operator double(Ampere value) => value.Value;
   
}

