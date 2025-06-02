using System.Text;
using Trainer.Helpers;

namespace Trainer.Abstractions;

internal abstract class Pokemon
{
    private string _name;
    private int _level;
    private Random _random = new();
    protected List<Attack> Attacks { get; }

    public string Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException($"'{nameof(value)}' can not be empty.");

            if (value.Length < 2 || value.Length > 15)
                throw new ArgumentException($"'{nameof(value)}' should be between 2 and 15 characters");

            _name = value;
        }
    }

    public int Level
    {
        get { return _level; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Level must be greater than 0", nameof(value));

            _level = value;
        }
    }

    public ElementType Type { get; }

    public Pokemon(string name, int level, ElementType type, List<Attack> attacks)
    {
        Name = name;
        Level = level;
        Type = type;
        Attacks = attacks ?? [];
    }

    public void RaiseLevel()
    {
        Level++;
        ConsoleUI.Output(GetLevelMessage());
    }

    public void Attack()
    {
        int attackIndex = GetUserAttackIndex();
        var message = GetAttackMessage(attackIndex - 1);
        ConsoleUI.Output(message);
    }

    public void RandomAttack()
    {
        int attackIndex = GetRandomAttackIndex();
        var message = GetAttackMessage(attackIndex);
        ConsoleUI.Output(message);
    }

    internal string GetLevelMessage()
    {
        return $"{Name} leveled up to {Level}";
    }

    internal string GetAttackList()
    {
        var builder = new StringBuilder();
        for (int i = 0; i < Attacks.Count; i++)
            builder.AppendLine($"{i + 1}. {Attacks[i].Name}");
        return builder.ToString();
    }

    internal int GetRandomAttackIndex()
    {
        return _random.Next(Attacks.Count);
    }

    internal int GetUserAttackIndex()
    {
        var prompt = $"Choose Attack:\n{GetAttackList()}";
        var attackIndex = ConsoleUI.GetNumberInRange(prompt, 0, Attacks.Count);
        return attackIndex;
    }

    internal string GetAttackMessage(int attackIndex)
    {
        if (attackIndex < 0 || attackIndex >= Attacks.Count)
            throw new ArgumentOutOfRangeException($"'{nameof(attackIndex)}' is not valid");

        return Attacks[attackIndex].Use(Level);
    }
}
