using Trainer.Helpers;

namespace Trainer.Abstractions;

internal abstract class ElectricPokemon : Pokemon
{
    public ElectricPokemon(string name, int level, List<Attack> attacks)
        : base(name, level, ElementType.Fire, attacks) { }
}
