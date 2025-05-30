using TrainerSimulator.Helpers;

namespace TrainerSimulator.Pokemon;

internal class FirePokemon : Pokemon
{
    public FirePokemon(string name, int level, List<Attack> attacks)
        : base(name, level, ElementType.Fire, attacks) { }
}
