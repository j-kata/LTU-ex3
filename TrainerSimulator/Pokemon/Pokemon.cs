using System.Text;
using TrainerSimulator.Helpers;

namespace TrainerSimulator.Pokemon;

// TODO: rename folder. Move named classes out of this folder
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
        Console.WriteLine($"{Name} leaveled up to {++Level}");
    }

    public void Attack()
    {
        var prompt = $"Choose Attack:\n{AttackList()}";
        var attackIndex = GetValidIndex(prompt, 0, Attacks.Count);
        PrintAttack(attackIndex - 1);
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
    private string AttackList()
    {
        var builder = new StringBuilder();
        for (int i = 0; i < Attacks.Count; i++)
            builder.AppendLine($"{i + 1}. {Attacks[i].Name}");
        return builder.ToString();
    }

    // TODO: move to helpers
    private static int GetValidIndex(string prompt, int min, int max = int.MaxValue)
    {
        int index = -1;
        bool isValid = false;
        do
        {
            Console.WriteLine(prompt);
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
