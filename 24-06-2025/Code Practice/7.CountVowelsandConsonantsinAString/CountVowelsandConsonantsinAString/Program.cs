using System;
class Program {
    static void Main()
    {
        List<string> ls = new List<string> {"a","e","i","o","u"};
        List<string> vow = new List<string> ();
        List<string> Cons = new List<string> ();

        Console.Write("Enter any String");
        string UserInput = Console.ReadLine();
        for (int i = 0; i < UserInput.Length; i++)
        {
            if (ls.Contains(UserInput[i].ToString().ToLower()))
            {
                vow.Add(UserInput[i].ToString());
            }
            else
            {
                Cons.Add(UserInput[i].ToString());
            }
        }

        Console.WriteLine("Vowels : " +  vow.Count);
        Console.WriteLine("Consonants : " +  Cons.Count);

    }
}

