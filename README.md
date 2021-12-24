# Industrial Electrical parameters 



[![.NET](https://github.com/araxis/IndustrialElectricityUnits/actions/workflows/dotnet.yml/badge.svg)](https://github.com/araxis/IndustrialElectricityUnits/actions/workflows/dotnet.yml)
[![NuGet](https://img.shields.io/nuget/v/Arax.Electricity.Parameters.svg)](https://www.nuget.org/packages/Arax.Electricity.Parameters)
[![NuGet](https://img.shields.io/nuget/dt/Arax.Electricity.Parameters.svg)](https://www.nuget.org/packages/Arax.Electricity.Parameters) 

set of electrical parameters such as Power, Current, Reactive power, Cos𝛟 etc, and related operators.

You should install [with NuGet](https://www.nuget.org/packages/Arax.Electricity.Parameters):

    Install-Package Arax.Electricity.Parameters
    
Or via the .NET Core command line interface:

    dotnet add package Arax.Electricity.Parameters
    
# Usage Sample

> on 3-Phase systems

> current in ampere = (Watt / Voltage x CosPhi x Efficiency x 1.73)

```csharp
   //very similar to the real formula
   public Current CalcCurrent(Power power,Voltage voltage, CosPhi cosPhi,Efficiency efficiency)
    {
        
       Ampere current = power.ToWatt() / (voltage * cosPhi * efficiency * 1.73);
       return current;

    } 
    
    // and simple call 
    var current = CalcCurrent(2.Kw(), 415, .89 , 90);
 
 ```
# Parameters
* CosPhi
* Efficiency
* Voltage (V)
* Current (A)
* Power (W,kW,HP)
* Apparent Power (VA,kVA)
* Reactive Power (VAr,kVAr)
* Circuit Breaker Type (Tmb, Mccb, Acb, Fuse)
* Start Mode (DOL, SD, SSD, VSD)
* And more soon....


### Power factor (value 0-1)
```csharp
     var cosPhi1 = new CosPhi(.7);
     var cosPhi2 = .7.Pf();
     CosPhi cosPhi3 = .7;
     
     //access value
     var value1 = cosPhi1.Value;
     double value2 = cosPhi1;
```
 ### Efficiency (value 0-1)
```csharp
     var efficiency1 =  new Efficiency(87);
     var efficiency2=87.Ef();
     Efficiency efficiency3 = 87;
    
    //to simplify usage, Value property return input/100;
    var value1 = efficiency1.Value; 
    double value2 = efficiency;
    //value is 0.87;
```
 ### Voltage (value > 0)
```csharp
     var voltage1 =  new Voltage(415);
     Voltage voltage2 = 415;
     var voltage3 = 415.V();   
   
    // access value
    var value1 = voltage1.Value; 
    double value2 = voltage1
```
### Current (value >= 0)
```csharp

     Current ampere =  new Ampere(1);
     Ampere ampere2 = 2;
     Current ampere3 = 3.A();
     var ampere4 = 4.A()
   
    //access value
    double value1 = ampere.Value; 
    double value2 = ampere;
    string unit = ampere.Unit; //"A"
```
 ### Power (value >= 0)
```csharp
     Power power1 =  new Watt(1);
     Power power2 =  new KiloWatt(1);
     Power power3 = new HorsePower(1)
     var power4 = 1.W();
     var power5 = 1.Kw();
     Watt Power6 = 1;
     HorsePower power7 = 1;
     var hpToWatt = power7.ToWatt();
   
    //access value
    double value1 = power1.Value; 
    double value2 = power2;
    string unit = power1.Unit;
```
### Apparent power (value >= 0)
```csharp
 
     ApparentPower power1 =  new VoltAmpere(1);
     ApparentPower power2 =  new KiloVoltAmpere(1);
     var power3 = 1.VA();
     VoltAmpere power6 = 1;
     KiloVoltAmpere power7 = 1;

    //access value
    double value1 = power1.Value; 
    double value2 = power2;
    string unit = power1.Unit;
```
 ### Reactive power (value >= 0)
```csharp
     ReactivePower power1 =  new VoltAmpereReactive(1);
     ReactivePower power2 =  new KiloVoltAmpereReactive(1);
     var power3 = 1.VAr();
     KiloVoltAmpereReactive power6 = 1;
     KiloVoltAmpere power7 = 1;

    //access value
    double value1 = power1.Value; 
    double value2 = power2;
    string unit = power1.Unit;
```
### Circuit Breaker Type
```csharp
 var tmb = CircuitBreakerType.Tmb;
 var mccb = CircuitBreakerType.Mccb;
 var acb = CircuitBreakerType.Acb;
 var fuse = CircuitBreakerType.Fuse;
 //properties
 int value = tmb.Value; // 0
 string name = tmb.Name; // "TMB"
 string description =tmb.Description; // "Thermal Magnetic Breaker"
```

### Start mode
```csharp
 var dol = StartMode.Dol;
 var sd = StartMode.Sd;
 var ssd = StartMode.Ssd;
 var vsd = StartMode.Vsd;
 //properties
 int value = dol.Value; // 0
 string name = dol.Name; // "DOL"
 string description =dol.Description; // "Direct Online"
```
### Power System
```csharp
 var singlePhase = PowerSystem.SinglePhase;
 var twoPhase = PowerSystem.TwoPhase;
 var threePhase = PowerSystem.ThreePhase;
 //properties
 int value = singlePhase.Value; // 0
 string name = dol.Name; // "Single Phase"
```
