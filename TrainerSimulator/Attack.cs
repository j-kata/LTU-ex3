using TrainerSimulator.Helpers;

namespace TrainerSimulator;

internal class Attack
{
    private string Name { get; set; }
    private ElementType Type { get; set; }
    private int BasePower { get; set; }

    public Attack(string name, ElementType type, int basePower)
    {
        Name = name;
        Type = type;
        BasePower = basePower;
    }
}
