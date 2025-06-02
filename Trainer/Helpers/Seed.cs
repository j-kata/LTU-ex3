using Trainer.Abstractions;
using Trainer.PokemonType;

namespace Trainer.Helpers;

internal static class Seed
{
    private static readonly Dictionary<string, Attack> attacks = new()
    {
        { "Flamethrower", new Attack("Flamethrower", ElementType.Fire, 12) },
        { "Ember", new Attack("Ember", ElementType.Fire, 6) },
        { "FireSpin", new Attack("Fire Spin", ElementType.Fire, 8) },
        { "FlameWheel", new Attack("Flame Wheel", ElementType.Fire, 10) },
        { "WaterGun", new Attack("Water Gun", ElementType.Water, 6) },
        { "BubbleBeam", new Attack("Bubble Beam", ElementType.Water, 10) },
        { "Hydro Pump", new Attack("Hydro Pump", ElementType.Water, 12) },
        { "Bubble", new Attack("Bubble", ElementType.Water, 6) },
        { "WaterPulse", new Attack("Water Pulse", ElementType.Water, 10) },
        { "ThunderShock", new Attack("Thunder Shock", ElementType.Electric, 6) },
        { "Thunderbolt", new Attack("Thunderbolt", ElementType.Electric, 12) },
        { "Spark", new Attack("Spark", ElementType.Electric, 8) },
    };

    // TODO: add other pokemon. Is dictionary the best way?
    public static List<Pokemon> GetPokemon()
    {
        return
        [
            new Charmander("Charmander", 3, [attacks["Flamethrower"], attacks["Ember"]]),
            new Squirtle("Squirtle", 4, [attacks["WaterGun"], attacks["BubbleBeam"]]),
            new Pikachu("Pikachu", 4, [attacks["ThunderShock"], attacks["Thunderbolt"]]),
        ];
    }
}
