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
                try
                {
                    pokemon.RaiseLevel();
                    pokemon.RandomAttack();
                    //pokemon.Attack();

                    if (pokemon is IEvolvable evolvable)
                        evolvable.Evolve();
                }
                catch (Exception ex)
                {
                    ConsoleUI.Output($"An error occurred for {pokemon.Name}: {ex.Message}");
                }
            }
            var prompt = "Do you want to see the next round? y/n";
            var input = ConsoleUI.GetSpecificString(prompt, ["y", "n"]);
            isRunning = !input.Equals("n", StringComparison.CurrentCultureIgnoreCase);
        }   
    }
}
