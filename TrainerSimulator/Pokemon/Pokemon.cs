using TrainerSimulator.Helpers;

namespace TrainerSimulator.Pokemon;

internal abstract class Pokemon
{
    private List<Attack> Attacks;

    public string Name { get; set; }
    public int Level { get; set; }
    public ElementType Type { get; }

    // TODO: add validations
    public Pokemon(string name, int level, ElementType type, List<Attack> attacks)
    {
        Name = name;
        Level = level;
        Type = type;
        Attacks = attacks;
    }

    public void RaiseLevel()
    {
        Console.Write($"{Name} leaveled up to {++Level}");
    }

    public abstract string Attack();
}
