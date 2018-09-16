/*
Pascal's Triangle

Wikipedia article on Pascal's Triangle: http://en.wikipedia.org/wiki/Pascal's_triangle

Write a function that, given a depth (n), returns a single-dimensional array representing Pascal's Triangle to the n-th level.

For example:

Kata.PascalsTriangle(4) == new List<int> {1,1,1,1,2,1,1,3,3,1}
*/
using System;
using System.Collections.Generic;

public static class Kata
{
    public static List<int> PascalsTriangle(int n)
    {    
        List<int> res = new List<int>() { 1 };
        for (int i = 2; i < n + 1; i++)
            for (int j = 0; j < i; j++)
                    res.Add(j == 0 || j == i - 1 ? 1 : res[res.Count - i] + res[res.Count - i + 1]);
        return res;
    }
}