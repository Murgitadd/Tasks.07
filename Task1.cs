using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 0)
            {
                char[] letters = words[i].ToCharArray();
                letters[0] = char.ToUpper(letters[0]);
                for (int j = 1; j < letters.Length; j++)
                {
                    letters[j] = char.ToLower(letters[j]);
                }
                words[i] = new string(letters);
            }
        }

        string capitalizedSentence = string.Join(" ", words);
        Console.WriteLine("Capitalized Sentence: " + capitalizedSentence);

        Console.ReadLine();
    }
}
