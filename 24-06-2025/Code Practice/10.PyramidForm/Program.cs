//## 🔹 **Task 10: Print Numbers in Pyramid Form**

//```
//    1
//   1 2
//  1 2 3
// 1 2 3 4
//1 2 3 4 5
//```

//> Pattern - based logic with nested loops

using System;

class Program
{
    static void Main()
    {
        int rows = 5;

        for (int i = 1; i <= rows; i++)
        {
            // Print spaces
            for (int space = 1; space <= rows - i; space++)
            {
                Console.Write(" ");
            }

            // Print numbers from 1 to i
            for (int num = 1; num <= i; num++)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
        }
    }
}

