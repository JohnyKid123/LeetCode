public class Solution {
    public int LengthOfLongestSubstring(string s) {
    int n = s.Length;
    int maxLen = 0;
    int left = 0, right = 0;
    HashSet<char> set = new HashSet<char>();
    
    while (right < n) {
        if (!set.Contains(s[right])) {
            set.Add(s[right]);
            right++;
            maxLen = Math.Max(maxLen, right - left);
        }
        else {
            set.Remove(s[left]);
            left++;
        }
    }
    
    return maxLen;
}

}
