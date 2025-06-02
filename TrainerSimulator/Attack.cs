using TrainerSimulator.Helpers;

namespace TrainerSimulator;

internal class Attack
{
    public string Name { get; private set; }
    public ElementType Type { get; private set; }
    private int BasePower { get; set; }

    public Attack(string name, ElementType type, int basePower)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentNullException($"'{nameof(name)}' can not be empty.");
        }

        Name = name;
        Type = type;
        BasePower = basePower;
    }

    public string Use(int level)
    {
        return $"{Name} hits with total power {TotalPower(level)}!";
    }

    public int TotalPower(int level)
    {
        if (level <= 0)
        {
            throw new ArgumentException("Level must be greater than 0", nameof(level));
        }
        return level + BasePower;
    }
}
