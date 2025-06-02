namespace Trainer.Tests;

using TrainerSimulator;
using TrainerSimulator.Helpers;
using TrainerSimulator.Pokemon;

public class AttackTests
{
    [Fact]
    public void TotalPower_ShouldReturnLevelSum()
    {
        // Arrange
        var attack = new Attack("Flamethrower", ElementType.Fire, 12);

        // Act
        var totalPower = attack.TotalPower(20);

        // Assert
        Assert.Equal(32, totalPower);
    }
}
