/*
Description:
Write a function that takes a string of braces, and determines if the order of the braces is valid.
It should return true if the string is valid, and false if it's invalid.

This Kata is similar to the Valid Parentheses Kata, but introduces new characters: brackets [], and curly braces {}. 
Thanks to @arnedag for the idea!

All input strings will be nonempty, and will only consist of parentheses, brackets and curly braces: ()[]{}.

What is considered Valid?
A string of braces is considered valid if all braces are matched with the correct brace.
*/
using System;
using System.Linq;
using System.Collections.Generic;

public class Brace {

        private static IDictionary<char, char> _bracesMap = new Dictionary<char, char>() 
        {
            {'(', ')'},
            {'{', '}'},
            {'[', ']'}
        };

        public static bool validBraces(String braces)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var c in braces)
            {
                if (stack.Count > 0 && _bracesMap.ContainsKey(stack.Peek()) && _bracesMap[stack.Peek()] == c) stack.Pop();
                else stack.Push(c);
            }
            return stack.Count == 0;
        }
}