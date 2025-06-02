namespace Trainer.Helpers;

internal static class ConsoleUI
{
    public static int GetNumberInRange(string prompt, int min, int max = int.MaxValue)
    {
        int num;
        bool isValid = false;
        do
        {
            Output(prompt);
            var input = Input();

            if (int.TryParse(input, out num))
            {
                if (min < num && num <= max)
                    isValid = true;
            }
        } while (!isValid);
        return num;
    }

    public static string GetSpecificString(string prompt, string[] variants)
    {
        bool isValid;
        string str;
        do
        {
            Output(prompt);
            str = Input();
            isValid = variants.Contains(str, StringComparer.OrdinalIgnoreCase);

        } while (!isValid);
        return str;
    }

    public static string Input()
    {
        return Console.ReadLine()?.Trim() ?? "";
    }

    public static void Output(string output)
    {
        Console.WriteLine(output);
    }
}