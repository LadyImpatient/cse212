using System;
using System.Collections.Generic;

class D
{
    static void Main()
    {
        int[] d = R(5);
        Array.Sort(d);
        Console.WriteLine("Values: " + string.Join(", ", d));
        int s = C(d);
        Console.WriteLine("Total: " + s);
    }

    static int[] R(int n)
    {
        Random r = new Random();
        int[] d = new int[n];
        for (int i = 0; i < n; i++)
        {
            d[i] = r.Next(1, 7);
        }
        return d;
    }

    static int C(int[] d)
    {
        int s = 0;
        Dictionary<int, int> c = new Dictionary<int, int>();
        foreach (int x in d)
        {
            if (c.ContainsKey(x))
            {
                c[x]++;
            }
            else
            {
                c[x] = 1;
            }
        }
        foreach (int v in c.Values)
        {
            switch (v)
            {
                case 2:
                    s += 10;
                    break;
                case 3:
                    s += 20;
                    break;
                case 4:
                    s += 30;
                    break;
                case 5:
                    s += 40;
                    break;
            }
        }
        return s;
    }
}


//Main()
//
//R(5) -> Generates an array of 5 random integers between 1 and 6
//  Random.Next() -> Generates a random integer between 1 and 6
//  Array.Sort() -> Sorts the generated array of integers in ascending order
//  Console.WriteLine() -> Outputs the sorted array of integers
//  C(d) -> Calculates a score based on the occurrences of values in the sorted array
     //Dictionary<int, int> c = new Dictionary<int, int>() -> Initializes a dictionary to store the count of occurrences of each value
     //foreach (int x in d) -> Iterates over the sorted array
     //     if (c.ContainsKey(x)) -> Checks if the value is already present in the dictionary
     //     c[x]++ -> Increments the count of occurrences for the value
     //     else -> If the value is not present in the dictionary
     //     c[x] = 1 -> Adds the value to the dictionary with a count of 1
     //     foreach (int v in c.Values) -> Iterates over the values in the dictionary
          //    switch (v) -> Determines the score based on the count of occurrences
               //   case 2 -> Adds 10 to the score for each value that occurs twice
               //   case 3 -> Adds 20 to the score for each value that occurs three times
               //   case 4 -> Adds 30 to the score for each value that occurs four times
               //   case 5 -> Adds 40 to the score for each value that occurs five times

//Console.WriteLine() -> Outputs the total score calculated

//if d had values of [2,2,3,3,3]: Display 30
