using Trainer.Abstractions;

namespace Trainer.PokemonType;

internal class Psyduck : WaterPokemon
{
    public Psyduck(string name, int level, List<Attack> attacks)
        : base(name, level, attacks) { }
}
