namespace Trainer.Tests;

using Trainer;
using Trainer.Helpers;
using Trainer.PokemonType;

public class IEvolveTests
{
    [Fact]
    public void Evolve_ShouldChangeNameAndIncreaseLevel()
    {
        var attacks = new List<Attack> {
            new("Thunder Shock", ElementType.Electric, 6),
            new("Thunderbolt", ElementType.Electric, 12)
        };
        var pikachu = new Pikachu("Pikachu", 15, attacks);

        pikachu.Evolve();

        Assert.Equal("Raichu", pikachu.Name);
        Assert.Equal(25, pikachu.Level);
    }

    [Fact]
    public void Evolve_ShouldEvolveOnlyOnce()
    {
        var attacks = new List<Attack> {
            new("Thunder Shock", ElementType.Electric, 6),
            new("Thunderbolt", ElementType.Electric, 12)
        };
        var pikachu = new Pikachu("Pikachu", 15, attacks);

        pikachu.Evolve();
        Assert.Equal(25, pikachu.Level);

        pikachu.Evolve();
        Assert.Equal(25, pikachu.Level);
    }
}