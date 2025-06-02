using Trainer.Abstractions;

namespace Trainer.PokemonType;

internal class Squirtle : WaterPokemon
{
    public Squirtle(string name, int level, List<Attack> attacks)
        : base(name, level, attacks) { }
}
