namespace Trainer.Tests;

using Trainer;
using Trainer.Helpers;
using Trainer.PokemonType;

public class PokemonTests
{
    [Fact]
    public void Constructor_ShouldThrowArgumentException_WhenNameIsEmptyOrNull()
    {
        Assert.Throws<ArgumentException>(() => new Pikachu("  ", 12, []));
        Assert.Throws<ArgumentException>(() => new Pikachu(null, 12, []));
    }

    [Fact]
    public void Constructor_ShouldThrowArgumentException_WhenNameIsOutOfRange()
    {
        Assert.Throws<ArgumentException>(() => new Pikachu("P", 12, []));
        Assert.Throws<ArgumentException>(() => new Pikachu("123456789abcdefg", 12, []));
    }

    [Fact]
    public void Constructor_ShouldThrowArgumentException_WhenLevelIsLessZeroOrNegative()
    {
        Assert.Throws<ArgumentException>(() => new Pikachu("Pikachu", 0, []));
        Assert.Throws<ArgumentException>(() => new Pikachu("Pikachu", -3, []));
    }

    [Fact]
    public void Constructor_ShouldThrowArgumentException_WhenSetNameIsEmptyOrNull()
    {
        var pokemon = new Squirtle("Squirtle", 12, []);
        Assert.Throws<ArgumentException>(() => pokemon.Name = "  ");
        Assert.Throws<ArgumentException>(() => pokemon.Name = null);
    }

    [Fact]
    public void Constructor_ShouldThrowArgumentException_WhenSetNameIsOutOfRange()
    {
        var pokemon = new Squirtle("Squirtle", 12, []);
        Assert.Throws<ArgumentException>(() => pokemon.Name = "S");
        Assert.Throws<ArgumentException>(() => pokemon.Name = "123456789abcdefg");
    }

    [Fact]
    public void Constructor_ShouldThrowArgumentException_WhenSetLevelIsZeroOrNegative()
    {
        var pokemon = new Squirtle("Squirtle", 12, []);
        Assert.Throws<ArgumentException>(() => pokemon.Level = 0);
        Assert.Throws<ArgumentException>(() => pokemon.Level = -3);
    }

    [Fact]
    public void Constructor_ShouldDefaultToEmptyList_WhenAttacksIsNull()
    {
        var pokemon = new Pikachu("Pikachu", 5, null);
        Assert.Empty(pokemon.GetAttackList());
    }

    [Fact]
    public void RaiseLevel_ShouldIncrementLevel()
    {
        var pokemon = new Charmander("Charmander", 1, []);
        pokemon.RaiseLevel();
        Assert.Equal(2, pokemon.Level);
    }

    [Fact]
    public void GetLevelMessage_ShouldReturnExpectedString()
    {
        var pokemon = new Charmander("Charmander", 1, []);
        pokemon.RaiseLevel();
        var message = pokemon.GetLevelMessage();
        Assert.Equal("Charmander leveled up to 2", message);
    }

    [Fact]
    public void GetAttackList_ShouldReturnExpectedString()
    {
        var attack1 = new Attack("Flamethrower", ElementType.Fire, 12);
        var attack2 = new Attack("Ember", ElementType.Fire, 6);
        var pokemon = new Charmander("Charmander", 5, [attack1, attack2]);

        var list = pokemon.GetAttackList();
        Assert.Equal("1. Flamethrower\n2. Ember\n", list);
    }

    [Fact]
    public void GetAttackMessage_ShouldReturnExpectedString()
    {
        var attack1 = new Attack("Flamethrower", ElementType.Fire, 12);
        var attack2 = new Attack("Ember", ElementType.Fire, 6);
        var pokemon = new Charmander("Charmander", 5, [attack1, attack2]);

        var message = pokemon.GetAttackMessage(1);
        Assert.Equal(attack2.Use(pokemon.Level), message);
    }

    [Fact]
    public void GetAttackMessage_ShouldThrowArgumentOutOfRangeException_WhenIndexIsOutOfRange()
    {
        var attack1 = new Attack("Flamethrower", ElementType.Fire, 12);
        var attack2 = new Attack("Ember", ElementType.Fire, 6);
        var pokemon = new Charmander("Charmander", 5, [attack1, attack2]);

        Assert.Throws<ArgumentOutOfRangeException>(() => pokemon.GetAttackMessage(-1));
        Assert.Throws<ArgumentOutOfRangeException>(() => pokemon.GetAttackMessage(2));
        Assert.Throws<ArgumentOutOfRangeException>(() => pokemon.GetAttackMessage(10));
    }

    [Fact]
    public void GetRandomAttackIndex_ShouldReturnExpectedIndex()
    {
        var attacks = new List<Attack>()
        {
            new("Flamethrower", ElementType.Fire, 12),
            new("Ember", ElementType.Fire, 6),
            new("Flame Wheel", ElementType.Fire, 10)
        };
        var pokemon = new Charmander("Charmander", 5, attacks);

        for (int i = 0; i < 100; i++)
        {
            int index = pokemon.GetRandomAttackIndex();
            Assert.InRange(index, 0, attacks.Count - 1);
        }
    }
}