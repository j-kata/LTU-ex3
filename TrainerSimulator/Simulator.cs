namespace TrainerSimulator;

internal class Simulator
{
    private List<Pokemon.Pokemon> _pokemon = [];

    public Simulator(List<Pokemon.Pokemon> pokemon)
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
