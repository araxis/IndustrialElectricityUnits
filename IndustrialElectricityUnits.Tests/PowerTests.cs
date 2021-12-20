using System;
using FluentAssertions;
using Xunit;

namespace IndustrialElectricityUnits.Tests;

public class PowerTests
{
    [Fact]
    public void NotAllowNegativeValueInWatt()
    {
        var construct = () => new Watt(-1);

        construct.Should().Throw<ArgumentException>();
    }

    [Fact]
    public void NotAllowNegativeValueInKiloWatt()
    {
        var construct = () => new KiloWatt(-1);
        construct.Should().Throw<ArgumentException>();
    }

    [Fact]
    public void NotAllowNegativeValueInHorsePower()
    {
        var construct = () => new HorsePower(-1);

        construct.Should().Throw<ArgumentException>();
    }

    [Fact]
    public void SumOfTwoPowerReturnResultInWatt()
    {
        double expectedResultValue = 1100;
        
        KiloWatt powerA = 1;
        Watt powerB = 100;

        var result = powerA + powerB;
       
        result.Should().BeOfType<Watt>().Which.Value.Should().Be(expectedResultValue);
        
    }
}