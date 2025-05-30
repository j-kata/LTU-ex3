using TrainerSimulator.Helpers;

namespace TrainerSimulator;

internal class Program
{
    private static void Main(string[] args)
    {
        var pokemon = Seed.GetPokemon();
        new Simulator(pokemon).Run();
    }
}
