using Trainer.Abstractions;

namespace Trainer;

internal class Simulator
{
    private List<Pokemon> _pokemon = [];

    public Simulator(List<Pokemon> pokemon)
    {
        _pokemon = pokemon;
    }

    // TODO: it is just one loop now. Add more
    public void Run()
    {
        foreach (var pokemon in _pokemon)
        {
            pokemon.RaiseLevel();
            pokemon.RandomAttack();

            if (pokemon is IEvolvable evolvable)
            {
                evolvable.Evolve();
            }
        }
    }
}
