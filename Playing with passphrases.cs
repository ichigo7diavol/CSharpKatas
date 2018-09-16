/*
Everyone knows passphrases. One can choose passphrases from poems, songs, movies names and so on but frequently they can be guessed due to common cultural references. You can get your passphrases stronger by different means. One is the following:

choose a text in capital letters including or not digits and non alphabetic characters,

shift each letter by a given number but the transformed letter must be a letter (circular shift),
replace each digit by its complement to 9,
keep such as non alphabetic and non digit characters,
downcase each letter in odd position, upcase each letter in even position (the first character is in position 0),
reverse the whole result.
#Example:

your text: "BORN IN 2015!", shift 1

1 + 2 + 3 -> "CPSO JO 7984!"

4 "CpSo jO 7984!"

5 "!4897 Oj oSpC"

With longer passphrases it's better to have a small and easy program. Would you write it?
*/

using System;
using System.Linq;
public class PlayPass {
  private static string lib = "abcdefghijklmnopqrstuvwxyz";
  public static string playPass(string s, int n) {
    string shifted = lib.Substring(n) + lib.Substring(0, n);
    return string.Concat(s.ToLower().Select((c, i) => {
      if(lib.Contains(c)) {
        char r = shifted[lib.IndexOf(c)];
        return i % 2 == 0 ? Char.ToUpper(r) : r;
      }
      if(Char.IsDigit(c)) return (9 - Char.GetNumericValue(c)).ToString()[0];
      return c;
    }).Reverse());
  }
}