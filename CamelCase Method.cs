/*
Write simple .camelCase method (camel_case function in PHP, CamelCase in C# or camelCase in Java) for strings.
All words must have their first letter capitalized without spaces.

For instance:

camelCase("hello case"); // => "HelloCase"
camelCase("camel case word"); // => "CamelCaseWord"
*/

using System.Globalization;

namespace Kata
{
  public static class Problem
  {
    public static string CamelCase(this string str)  
    {  
      string capsMe = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
      return capsMe.Replace(" ", "");
    }
  }
}
