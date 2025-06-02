using Trainer.Abstractions;

namespace Trainer.PokemonType;

internal class Vulpix : FirePokemon
{
    public Vulpix(string name, int level, List<Attack> attacks)
        : base(name, level, attacks) { }
}
