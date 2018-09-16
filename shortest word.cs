/*
Simple, given a string of words, return the length of the shortest word(s).

String will never be empty and you do not need to account for different data types.
*/

using System.Linq;

public class Kata
{
  public static int FindShort(string s)
  {
    return s.Split(' ').Min(x => x.Length);
  }
}