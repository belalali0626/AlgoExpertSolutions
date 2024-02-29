public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        int[] count = new int[26];

        foreach (char c in s)
            count[c - 'a']++;

        foreach (char c in t)
        {
            if (--count[c - 'a'] < 0)
                return false;
        }

    }
}
