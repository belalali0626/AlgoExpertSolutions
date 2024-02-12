TwoSum C#

using System;
using System.Collections.Generic;

Hashset Solution 1



public class Program {
  public static int[] TwoNumberSum(int[] array, int targetSum) {
      HashSet<int> visited = new HashSet <int> ();
      int size = array.Length;

      for(int startIndex = 0; startIndex < size; startIndex++)
      {
          int difference = targetSum = array[startIndex];
          if(visited.Contains(difference))
          {
              return new int[] {array[startIndex], difference};
          }
          else{
              visited.Add(array[startIndex]);
          }
      }
      return new int[0];
    }
}


public class Program {
  public static int[] TwoNumberSum(int[] array, int targetSum) {
    HashSet<int> nums = new HashSet <int> ();
    foreach(int i in array)
    {
        if(nums.Contains(targetSum - i))
        {
            return new int[]{i, targetSum - i};
        }
        else{
            nums.Add(i);
        }
    }
      

    return new int[0];
  }
}

