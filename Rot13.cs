/*
ROT13 is a simple letter substitution cipher that replaces a letter with the letter 13 letters after it in the alphabet. ROT13 is an example of the Caesar cipher.

Create a function that takes a string and returns the string ciphered with Rot13. If there are numbers or special characters included in the string, they should be returned as they are. Only letters from the latin/english alphabet should be shifted, like in the original Rot13 "implementation".

Please note that using "encode" in Python is considered cheating.
*/

using System;

public class Kata
{
  public static string Rot13(string message)
  {
    string result = "";
            foreach (var s in message)
            {
                if ((s >= 'a' && s <= 'm') || (s >= 'A' && s <= 'M'))
                    result += Convert.ToChar((s + 13)).ToString();
                else if ((s >= 'n' && s <= 'z') || (s >= 'N' && s <= 'Z'))
                    result += Convert.ToChar((s - 13)).ToString();
                else result += s;
            }
            return result;
  }
}