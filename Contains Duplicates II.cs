
Contains Duplicate II

using System.Collections.Generic;

public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Dictionary<int, int> scannedNums = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            if(scannedNums.ContainsKey(nums[i]) && i - scannedNums[nums[i]] <= k)
            {
                return true;
            }
            else
            {
                scannedNums[nums[i]] = i;
            }
        }

        return false;
    }
}
