namespace TrainerSimulator.Pokemon;

internal class Pikachu : ElectricPokemon, IEvolvable
{
    public Pikachu(string name, int level, List<Attack> attacks)
        : base(name, level, attacks) { }

    // TODO: refactoring
    public void Evolve()
    {
        Console.Write($"{Name} is evolving...");

        Name = "Raichu";
        Level += 10;

        Console.WriteLine($"Now it's {Name}! Level {Level}");
    }
}
