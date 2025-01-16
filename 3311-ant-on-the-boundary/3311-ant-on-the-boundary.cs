public class Solution {
    public int ReturnToBoundaryCount(int[] nums) {
        int ans = 0;  
        int count = 0; 
        if (nums == null || nums.Length == 0) {
            return 0;
        }

        foreach (int num in nums) {
            ans += num; 
            if (ans == 0) {
                count++; 
            }
        }

        return count; 
    }
}
