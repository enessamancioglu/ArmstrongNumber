using System;

class CharacterCount
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int[] charCount = new int[256]; // Assuming ASCII characters

        CountCharacters(input, charCount);

        Console.WriteLine("Character Counts:");
        for (int i = 0; i < charCount.Length; i++)
        {
            if (charCount[i] > 0)
            {
                char c = (char)i;
                Console.WriteLine($"{c}: {charCount[i]}");
            }
        }
    }

    static void CountCharacters(string input, int[] charCount)
    {
        foreach (char c in input)
        {
            charCount[c]++;
        }
    }
}

