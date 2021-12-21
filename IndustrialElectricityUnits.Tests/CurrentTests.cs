using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace IndustrialElectricityUnits.Tests;

public class CurrentTests
{
    [Fact]
    public void NotAllowNegativeValueInAmpere()
    {

        var construct = () => new Ampere(-1);

        construct.Should().Throw<ArgumentException>();
    }

    [Fact]
    public void SumOfTwoCurrentReturnResultInAmpere()
    {
        double expectedResultValue = 100;

        var currentA = 40.A();
        var currentB = 60.A();

        var result = currentA + currentB;
       
        result.Should().BeOfType<Ampere>().Which.Value.Should().Be(expectedResultValue);
        
    }

    [Fact]
    public void DividedByNumberReturnResultInInputCurrentType()
    {
        double expectedResultValue = 50;
        
        var currentA = 100.A();
        var operand = 2;

        var result = currentA / operand;

        using var scope = new AssertionScope();
        result.Should().BeOfType(currentA.GetType());
        result.Value.Should().Be(expectedResultValue);
    }

    [Fact]
    public void MultiplyByNumberReturnResultInInputCurrentType()
    {
        double expectedResultValue = 200;
        
        var currentA = 100.A();
        var operand = 2;

        var result = currentA * operand;

        using var scope = new AssertionScope();
        result.Should().BeOfType(currentA.GetType());
        result.Value.Should().Be(expectedResultValue);
    }

    
 
}