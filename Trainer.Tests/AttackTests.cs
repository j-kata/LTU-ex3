namespace Trainer.Tests;

using Trainer;
using Trainer.Helpers;

public class AttackTests
{
    [Fact]
    public void TotalPower_ShouldReturnExpectedSum()
    {
        // Arrange
        var attack = new Attack("Flamethrower", ElementType.Fire, 12);

        // Act
        var totalPower = attack.TotalPower(100);

        // Assert
        Assert.Equal(112, totalPower);
    }

    [Fact]
    public void TotalPower_ShouldThrowArgumentException_WhenLevelIsZeroOrNegative()
    {
        var attack = new Attack("Flamethrower", ElementType.Fire, 12);

        Assert.Throws<ArgumentException>(() => attack.TotalPower(0));
        Assert.Throws<ArgumentException>(() => attack.TotalPower(-10));
    }

    [Fact]
    public void Use_ShouldReturnExpectedString()
    {
        var attack = new Attack("Flamethrower", ElementType.Fire, 12);

        var use = attack.Use(8);

        Assert.Equal("Flamethrower hits with total power 20!", use);
    }

    [Fact]
    public void Use_ShouldThrowArgumentException_WhenLevelIsZeroOrNegative()
    {
        var attack = new Attack("Flamethrower", ElementType.Fire, 12);

        Assert.Throws<ArgumentException>(() => attack.Use(0));
        Assert.Throws<ArgumentException>(() => attack.Use(-10));
    }

    [Fact]
    public void Constructor_ShouldThrowArgumentException_WhenNameIsEmptyOrNull()
    {
        Assert.Throws<ArgumentException>(() => new Attack("  ", ElementType.Fire, 12));
        Assert.Throws<ArgumentException>(() => new Attack(null, ElementType.Fire, 12));
    }

    [Fact]
    public void Constructor_ShouldThrowArgumentException_WhenBasePowerIsZeroOrNegative()
    {
        Assert.Throws<ArgumentException>(() => new Attack("Flamethrower", ElementType.Fire, 0));
        Assert.Throws<ArgumentException>(() => new Attack("Flamethrower", ElementType.Fire, -3));
    }
}
