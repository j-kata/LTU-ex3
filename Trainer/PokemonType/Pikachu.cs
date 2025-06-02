using Trainer.Abstractions;
using Trainer.Helpers;

namespace Trainer.PokemonType;

internal class Pikachu : ElectricPokemon, IEvolvable
{
    private bool HasEvolved { get; set; }

    public Pikachu(string name, int level, List<Attack> attacks)
        : base(name, level, attacks) { }

    public void Evolve()
    {
        if (HasEvolved) return;

        string oldName = Name;
        Name = "Raichu";
        Level += 10;
        HasEvolved = true;

        ConsoleUI.Output($"{oldName} is evolving...\nNow it's {Name}! Level {Level}!");
    }
}
