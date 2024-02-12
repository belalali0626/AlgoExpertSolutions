Validate Subsequence C#

using System;

public class Program 
{
  public int[] SortedSquaredArray(int[] array) 
  {
      var len = array.Length;
      var result = new int[len];
      for(int i = 0, leftOffset = 0, rightOffset = len - 1; i < len; i++)
          result[len - 1 - i] = array[rightOffset] <= Abs(array[leftOffset])
          ? Squared(array[leftOffset++])
          : Squared(array[rightOffset--]);
      return result;
  }
    private int Abs(int x) => (x ^ (x >> 31)) - (x >> 31);
    private int Squared(int val) => val * val;
}
