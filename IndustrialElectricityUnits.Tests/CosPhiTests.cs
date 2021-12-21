using System;
using FluentAssertions;
using Xunit;

namespace IndustrialElectricityUnits.Tests;

public class CosPhiTests
{
    [Fact]
    public void NotAllowValueLeesThanZero()
    {
        
        var cosPhi = () => new CosPhi(-1);
        cosPhi.Should().Throw<ArgumentException>();
    }

    [Fact]
    public void NotAllowValueGreaterThanOne()
    {
        var construct = () => new CosPhi(2);
        construct.Should().Throw<ArgumentException>();
    }


}