using System;
using FluentAssertions;
using Xunit;

namespace IndustrialElectricityUnits.Tests;

public class VoltageTests
{
    [Fact]
    public void NotAllowZeroValue()
    {
        var construct = () => new Voltage(0);
        construct.Should().Throw<ArgumentException>();
    }

    [Fact]
    public void NotAllowNegativeValue()
    {
        var contracts = () => new Voltage(-1);
        contracts.Should().Throw<ArgumentException>();
    }
}