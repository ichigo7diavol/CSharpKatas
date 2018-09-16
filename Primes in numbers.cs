/*
Description:
Given a positive number n > 1 find the prime factor decomposition of n.
The result will be a string with the following form :

 "(p1**n1)(p2**n2)...(pk**nk)"
with the p(i) in increasing order and n(i) empty if n(i) is 1.

Example: n = 86240 should return "(2**5)(5)(7**2)(11)"
*/

using System;
using System.Collections.Generic;

public class PrimeDecomp {
  public static String factors(int lst) {
    var primes = new List<string>();
    for (var number = 2; number <= lst; number++)
    {
      var count=0;
      while (lst % number == 0) { count++; lst /= number; }                
      if(count==0) continue;
      primes.Add( String.Format(count > 1 ? "({0}**{1})" : "({0})",number,count));
    }
    return String.Join("", primes);
  }
}