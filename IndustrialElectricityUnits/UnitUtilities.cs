namespace IndustrialElectricityUnits;

public static class UnitUtilities
{

    public static Watt W(this int value) => new(value);
    public static Watt W(this double value) => new (value);
    public static Power Kw(this double value) => new KiloWatt(value);
    public static Power Kw(this int value) => new KiloWatt(value);
    public static Voltage V(this int value) => new(value);
    public static Voltage V(this double value) => new(value);
    public static Current A(this double value) => new Ampere(value);
    public static Ampere ToA(this Current value) => value.ToAmpere();
    public static Current A(this int value) => new Ampere(value);
    public static Efficiency Ef(this int value) => new(value);
    public static Efficiency Ef(this double value) => new(value);
    public static CosPhi Pf(this double value) => new(value);

    public static VoltAmpere VA(this int value) => new(value);
    public static VoltAmpere VA(this double value) => new (value);
    public static VoltAmpereReactive VAr(this int value) => new(value);
    public static VoltAmpereReactive VAr(this double value) => new (value);
    public static VoltAmpereReactive ToVAr(this ReactivePower value) => value.ToVAr();
 
 
}