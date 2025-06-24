using System;
//Task 3: Print Fibonacci Series up to N Terms
class Program
{
    static void Main()
    {
        Console.Write("Enter how many Fibonacci numbers you want: ");

        int UserInput = int.Parse( Console.ReadLine());

        int First = 0;int second = 1;

        Console.WriteLine("Fibonacci Series:");

        for (int i = 0; i < UserInput; i++)
        {
            Console.Write(First+",");
            int next = First+second;
            First = second; second = next;  
        }

    }
} 