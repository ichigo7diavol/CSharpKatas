/*
Description:
What is an anagram? Well, two words are anagrams of each other if they both contain the same letters. For example:

'abba' & 'baab' == true

'abba' & 'bbaa' == true

'abba' & 'abbba' == false
Write a function that will find all the anagrams of a word from a list. You will be given two inputs a word and an array with words. You should return an array of all the anagrams or an empty array if there are none. For example:

Kata.Anagrams("abba", new List<string> {"aabb", "abcd", "bbaa", "dada"}) => new List<string> {"aabb", "bbaa"}

Kata.Anagrams("racer", new List<string> {"crazer", "carer", "racar", "caers", "racer"}) => new List<string> {"carer", "racer"}

Kata.Anagrams("laser", new List<string> {"lazing", "lazy", "lacer"}) => new List<string>()
*/

using System;
using System.Collections.Generic;

public class DirReduction {
    public static String[] dirReduc(String[] arr) {
        Stack<String> stack = new Stack<String>();

        foreach (String direction in arr) {
            String lastElement = stack.Count > 0 ? stack.Peek().ToString() : null;

            switch(direction) {
                case "NORTH": if ("SOUTH".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
                case "SOUTH": if ("NORTH".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
                case "EAST":  if ("WEST".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
                case "WEST":  if ("EAST".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
            }
        }
        String[] result = stack.ToArray();        
        Array.Reverse(result);
        
        return result;               
    }
}