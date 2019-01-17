using System;

namespace _2_SumOfEvenFibs
{
  class Program
  {
    /**
     * Analysis:
     *  Note 1:
     *    - Fibs always sum the previous two numbers, whether the outcome is odd or even is also based on the aforementioned two numbers.
     *    - Even + even = even;
     *    - Even + odd = odd;
     *    - Odd + odd = even;
     *    
     *  Note 2:
     *    - Fibs start with 1, 1, which is odd-odd, so we can get the pattern:
     *      - odd, odd, (even , odd, odd), (even, odd, odd), (even ..
     *      - Even occurs on N = 3, 6, 9, 12..
     *      
     *  Note 3:
     *    - Recursive programming may be a bit slow, please bring out Dynamic Programming you learned in undergrad!
     *    - Have fun tabulating! \o/
     */

    private static long[] fibTable;

    static void Main(String[] args)
    {
      long t = long.Parse(Console.ReadLine());
      for (long a0 = 0; a0 < t; a0++)
      {
        long upperLimit = long.Parse(Console.ReadLine());
        fibTable = new long[100000];

        long evenSum = 0;
        long iteration = 0;
        long fibN = 0;

        while(true) { 
          fibN = GetFib(iteration);

          if(fibN > upperLimit)
          {
            break;
          }

          if(iteration % 3 == 2) // We need to consider that arrays start from 0, hence 2 instead of 0.
          {
            evenSum += fibN;
          }

          iteration++;
        }
        Console.WriteLine(evenSum);

      }
    }

    static long GetFib(long n)
    {
      if(n == 0)
      {
        fibTable[n] = 1;
      }

      else if(n == 1)
      {
        fibTable[n] = 1;
      }

      else
      {
        if (fibTable[n] == 0)
        {
          fibTable[n] = fibTable[n - 1] + fibTable[n - 2];
        }
      }

      return fibTable[n];

    }
  }
}