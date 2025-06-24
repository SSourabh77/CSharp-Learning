using System;

class Program
{
    static void Main()
    {
        List<int> PrimeNumber = new List<int>();   
        for (int i = 2; i <= 100; i++)
        {
            bool isprime = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if(i%j == 0)
                {
                    isprime = false;
                }
                
            }
            if (isprime)
            {
                PrimeNumber.Add(i);
            }
        }
        foreach (int i in PrimeNumber)
        {
            Console.WriteLine(i.ToString());
        }
    }
}