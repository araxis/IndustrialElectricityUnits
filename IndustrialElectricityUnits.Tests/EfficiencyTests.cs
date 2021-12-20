using System;
using FluentAssertions;
using Xunit;

namespace IndustrialElectricityUnits.Tests;

public class EfficiencyTests
{
    [Fact]
    public void NotAllowValueLeesThan_0()
    {
        var construct = () => new Efficiency(-1);
        construct.Should().Throw<ArgumentException>();
    }

    [Fact]
    public void NotAllowValueGreaterThan_100()
    {
        var construct = () => new CosPhi(150);
        construct.Should().Throw<ArgumentException>();
    }
}