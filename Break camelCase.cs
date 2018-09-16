/*
using System;
using System.Linq;

public class Kata
{
  public static string BreakCamelCase(string str)
  {
    return string.Concat(str.Select(c => Char.IsUpper(c) ? " " + c : c.ToString()));
  }
}
*/

using System;
using System.Linq;

public class Kata
{
  public static string BreakCamelCase(string str)
  {
    return string.Concat(str.Select(c => Char.IsUpper(c) ? " " + c : c.ToString()));
  }
}