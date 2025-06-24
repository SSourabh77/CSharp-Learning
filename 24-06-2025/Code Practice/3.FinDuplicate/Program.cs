using System;
using System.Collections.Generic;
//### 🔹 **Task 9: Find Duplicate Elements in an Array**

//**Input:** `{ 1, 2, 3, 2, 4, 1, 5}`
//**Output:** `1 and 2 are duplicates`

//> Use nested loop (or dictionary if you want bonus)

//---
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the string to check for duplicate characters: ");
        var userInput = Console.ReadLine();

        List<string> seen = new List<string>();
        List<string> duplicates = new List<string>();

        for (int i = 0; i < userInput.Length; i++)
        {
            string ch = userInput[i].ToString().ToLower();
            if (seen.Contains(ch))
            {
                if (!duplicates.Contains(ch)) 
                {
                    duplicates.Add(ch);
                }
            }
            else
            {
                seen.Add(ch);
            }
        }

        if (duplicates.Count > 0)
        {
            Console.Write("Duplicates found: ");
            foreach (string s in duplicates)
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("No duplicate characters found.");
        }
    }
}
