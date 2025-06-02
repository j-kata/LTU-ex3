using Trainer.Helpers;

namespace Trainer;

internal class Program
{
    private static void Main(string[] args)
    {
        var pokemon = Seed.GetPokemon();
        new Simulator(pokemon).Run();
    }
}
