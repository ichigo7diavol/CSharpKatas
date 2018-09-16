/*
Description:
Given an array, find the int that appears an odd number of times.

There will always be only one integer that appears an odd number of times.
*/

using System.Linq;

namespace Solution
{
  class Kata
    {
      public static int find_it(int[] seq) 
      {
        return seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;
      }
    }
}