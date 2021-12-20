using System;
using FluentAssertions;
using Xunit;

namespace IndustrialElectricityUnits.Tests;

public class ApparentPowerTests
{
    [Fact]
    public void NotAllowNegativeValueInWatt()
    {
       
        var construct = () => new VoltAmpere(-1);

        construct.Should().Throw<ArgumentException>();
    }

    [Fact]
    public void NotAllowNegativeValueInKiloWatt()
    {
        var construct = () => new KiloVoltAmpere(-1);
        construct.Should().Throw<ArgumentException>();
    }
}