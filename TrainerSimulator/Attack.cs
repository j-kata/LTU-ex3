using TrainerSimulator.Helpers;

namespace TrainerSimulator;

internal class Attack
{
    private string Name { get; set; }
    private ElementType Type { get; set; }
    private int BasePower { get; set; }

    // TODO: add validations
    public Attack(string name, ElementType type, int basePower)
    {
        Name = name;
        Type = type;
        BasePower = basePower;
    }

    public string Use(int level)
    {
        return $"{Name} hits with total power {TotalPower(level)}!";
    }

    private int TotalPower(int level) => level + BasePower;
}
