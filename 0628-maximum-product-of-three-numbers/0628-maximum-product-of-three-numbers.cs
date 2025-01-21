public class Solution {
    public int MaximumProduct(int[] nums) {
        Array.Sort(nums);
        int n=nums.Length;
        int h=nums[n-1]*nums[n-2]*nums[n-3];
        int r=nums[0]*nums[1]*nums[n-1];
        return Math.Max(h,r);
    }
}