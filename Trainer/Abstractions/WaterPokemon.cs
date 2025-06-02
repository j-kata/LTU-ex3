using Trainer.Helpers;

namespace Trainer.Abstractions;

internal class WaterPokemon : Pokemon
{
    public WaterPokemon(string name, int level, List<Attack> attacks)
        : base(name, level, ElementType.Fire, attacks) { }
}
