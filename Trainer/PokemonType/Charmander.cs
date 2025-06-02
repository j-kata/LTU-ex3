using Trainer.Abstractions;

namespace Trainer.PokemonType;

internal class Charmander : FirePokemon
{
    public Charmander(string name, int level, List<Attack> attacks)
        : base(name, level, attacks) { }
}
