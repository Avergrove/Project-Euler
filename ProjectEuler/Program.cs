using System;

namespace ProjectEuler
{
  class Program
  {
    /**
     * The problem:
     * Find the sum of numbers which are multiples of 3 and 5, from [0,N).
     */ 

    /**
     * Explanation:
     * Note 1:
     *  Multiples of 3 and 5 form an Arithmetric Progression.
     *  sum3 = 3(1+2+3+4..)
     *  sum5 = 5(1+2+3+4..)
     * 
     *  We can exploit this to achieve linear time.
     * 
     * Note 2:
     *  sum15 needs to be deducted since it is added twice during the summing of sum3 with sum15.
     */

    static void Main(String[] args)
    {
      int t = Convert.ToInt32(Console.ReadLine());
      for (int a0 = 0; a0 < t; a0++)
      {
        long n = Int64.Parse(Console.ReadLine());
        long upperLimit = n - 1; // Since these numbers must be below N


        long sum = (3 * Summation(upperLimit / 3)) + (5 * Summation(upperLimit / 5)) - (15 * Summation(upperLimit / 15));

        Console.WriteLine(sum);
      }
    }

    private static long Summation(long n)
    {
      return n * (n + 1) / 2;
    }
  }
}
