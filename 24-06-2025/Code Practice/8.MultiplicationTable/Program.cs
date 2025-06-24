using System;

//---

//### 🔹 **Task 8: Create a Multiplication Table**

//**Input:** `5`
//**Output:**

//```
//5 x 1 = 5  
//5 x 2 = 10  
//...  
//5 x 10 = 50
//```

//> Use for loop with formatted output
class Program
{
    static void Main() {
        Console.WriteLine("Enter Number Which you want to print table : ");
        var UserInput  = Console.ReadLine();
        for (int i = 1; i <= 10; i++)
        {
            //Console.WriteLine(UserInput + "X" +i +" = " + int.Parse(UserInput)*i);
            Console.WriteLine($"{UserInput} X {i} = {int.Parse(UserInput) * i}");
        }
    }
}