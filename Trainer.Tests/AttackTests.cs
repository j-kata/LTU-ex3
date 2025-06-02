namespace Trainer.Tests;

using TrainerSimulator;
using TrainerSimulator.Helpers;

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
    public void TotalPower_ShouldThrowArgumentException_WhenLevelIsZero()
    {
        var attack = new Attack("Flamethrower", ElementType.Fire, 12);

        Assert.Throws<ArgumentException>(() => attack.TotalPower(0));
    }

    [Fact]
    public void TotalPower_ShouldThrowArgumentException_WhenLevelIsNegative()
    {
        var attack = new Attack("Flamethrower", ElementType.Fire, 12);

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
    public void Use_ShouldThrowArgumentException_WhenLevelIsZero()
    {
        var attack = new Attack("Flamethrower", ElementType.Fire, 12);

        Assert.Throws<ArgumentException>(() => attack.Use(0));
    }

    [Fact]
    public void Use_ShouldThrowArgumentException_WhenLevelIsNegative()
    {
        var attack = new Attack("Flamethrower", ElementType.Fire, 12);

        Assert.Throws<ArgumentException>(() => attack.Use(-10));
    }

    [Fact]
    public void Attack_ShouldThrowArgumentException_WhenNameIsEmpty()
    {
        Assert.Throws<ArgumentException>(() => new Attack("  ", ElementType.Fire, 12));
    }

    [Fact]
    public void Attack_ShouldThrowArgumentException_WhenNameIsNull()
    {
        Assert.Throws<ArgumentException>(() => new Attack(null, ElementType.Fire, 12));
    }

    [Fact]
    public void Attack_ShouldThrowArgumentException_WhenBasePowerIsZero()
    {
        Assert.Throws<ArgumentException>(() => new Attack("Flamethrower", ElementType.Fire, 0));
    }

    [Fact]
    public void Attack_ShouldThrowArgumentException_WhenBasePowerIsNegative()
    {
        Assert.Throws<ArgumentException>(() => new Attack("Flamethrower", ElementType.Fire, -3));
    }
}
