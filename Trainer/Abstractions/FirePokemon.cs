using Trainer.Helpers;

namespace Trainer.Abstractions;

internal class FirePokemon : Pokemon
{
    public FirePokemon(string name, int level, List<Attack> attacks)
        : base(name, level, ElementType.Fire, attacks) { }
}
