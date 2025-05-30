using TrainerSimulator.Helpers;

namespace TrainerSimulator.Pokemon;

internal class WaterPokemon : Pokemon
{
    public WaterPokemon(string name, int level, List<Attack> attacks)
        : base(name, level, ElementType.Fire, attacks) { }
}
