/*
Write a function called that takes a string of parentheses, and determines if the order of the parentheses is valid.
The function should return true if the string is valid, and false if it's invalid.

Examples
"()"              =>  true
")(()))"          =>  false
"("               =>  false
"(())((()())())"  =>  true
Constraints
0 <= input.length <= 100

Along with opening (() and closing ()) parenthesis, input may contain any valid ASCII characters.
Furthermore, the input string may be empty and/or not contain any parentheses at all.
Do not treat other forms of brackets as parentheses (e.g. [], {}, <>).
*/
using System.Text;

public class Parentheses
{
    public static bool ValidParentheses(string input)
    {
        var count = 0;
        foreach(var c in input)
        {
          if(count == -1)
            return false;
          if(c == '(')
            count++;
          if(c == ')')
            count --;
        }
        return count == 0;
    }
}