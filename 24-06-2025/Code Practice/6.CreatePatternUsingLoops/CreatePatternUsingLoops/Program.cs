using System;

//Task 5: Create a Pattern Using Loops

//Print this pattern using nested `for` loops:

//```
//*
//**
//***
//****
//*****
//```

//---
class Program
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            for(int j = 1; j <=i; j++)
            {
                Console.Write("*");

            }
            Console.WriteLine();
        }
    }
}