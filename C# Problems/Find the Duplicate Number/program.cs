public class Solution {
    public int FindDuplicate(int[] nums) {
    HashSet<int> set = new HashSet<int>();
    foreach (int num in nums) {
        if (set.Contains(num)) {
            return num;
        } else {
            set.Add(num);
        }
    }
    return -1; 
}

}
