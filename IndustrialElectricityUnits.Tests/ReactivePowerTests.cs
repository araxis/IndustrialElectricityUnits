using System;
using FluentAssertions;
using Xunit;

namespace IndustrialElectricityUnits.Tests;

public class ReactivePowerTests
{
    [Fact]
    public void NotAllowNegativeValueInWatt()
    {
        var construct = () => new VoltAmpereReactive(-1);

        construct.Should().Throw<ArgumentException>();
    }

    [Fact]
    public void NotAllowNegativeValueInKiloWatt()
    {
        var construct = () => new KiloVoltAmpereReactive(-1);
        construct.Should().Throw<ArgumentException>();
    }
}