using System;
using System.Text;
//### 🔹 **Task 6: Check if a Number is Palindrome**

//**Input:** `121`
//**Output:** `Yes, it's a palindrome`

//**Input:** `123`
//**Output:** `No, it's not a palindrome`
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Number which want to check Palindrome : ");
        string userInput = Console.ReadLine();
        //string checkStr = "";

        StringBuilder checkStr = new StringBuilder();
        for (int i = userInput.Length-1; i >=0; i--)
        {
            //checkStr = checkStr + userInput[i];
            checkStr.Append(userInput[i]);
        }
        if(checkStr.ToString() == userInput)
        {
            Console.WriteLine(userInput + " Yes, it's a palindrome");
        }
        else
        {
            Console.WriteLine(userInput + " No, it's not a palindrome");

        }
    }
}