using TrainerSimulator.Helpers;

namespace TrainerSimulator.Pokemon;

internal abstract class Pokemon
{
    protected List<Attack> Attacks;

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

    public void Attack()
    {
        PrintAttackList();
        var attackIndex = GetValidIndex(0, Attacks.Count);
        PrintAttack(attackIndex);
    }

    public void RandomAttack()
    {
        int attackIndex = new Random().Next(0, Attacks.Count);
        PrintAttack(attackIndex);
    }

    // TODO: add validation
    private void PrintAttack(int attackIndex)
    {
        var attack = Attacks[attackIndex].Use(Level);
        Console.WriteLine(attack);
    }

    // TODO: Attacks.ToString()?
    private void PrintAttackList()
    {
        for (int i = 0; i < Attacks.Count; i++)
            Console.WriteLine($"{i + 1}. {Attacks[i].Name}");
    }

    // TODO: move to helpers
    private static int GetValidIndex(int min, int max = int.MaxValue)
    {
        int index = -1;
        bool isValid = false;
        do
        {
            var input = Console.ReadLine()?.Trim() ?? "";

            if (int.TryParse(input, out index))
            {
                if (min < index && index <= max)
                    isValid = true;
            }
        } while (!isValid);
        return index;
    }
}
