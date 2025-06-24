using System;
//### 🔹 **Task 7: Sum of Digits of a Number**

//**Input:** `567`
//**Output:** `5 + 6 + 7 = 18`
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Number Which you want to add : ");
        string UserInput = Console.ReadLine();
        int Total = 0;
        for (int i = 0; i <= UserInput.Length-1; i++)
        {
            Total = Total + int.Parse(UserInput[i].ToString());
        }
        Console.WriteLine(Total);
    }
}