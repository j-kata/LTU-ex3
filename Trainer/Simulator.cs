using Trainer.Abstractions;
using Trainer.Helpers;

namespace Trainer;

internal class Simulator
{
    private List<Pokemon> _pokemon = [];

    public Simulator(List<Pokemon> pokemon)
    {
        _pokemon = pokemon;
    }

    public void Run()
    {
        bool isRunning = true;
        while (isRunning)
        {
            foreach (var pokemon in _pokemon)
            {
                pokemon.RaiseLevel();
                pokemon.RandomAttack();
                //pokemon.Attack();

                if (pokemon is IEvolvable evolvable)
                    evolvable.Evolve();
            }
            var prompt = "Do you want to see the next round? y/n";
            var input = ConsoleUI.GetSpecificString(prompt, ["y", "n"]);
            if (input == "n") isRunning = false;
        }
        
    }
}
