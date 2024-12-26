public class Solution {
    public int FindNonMinOrMax(int[] nums) {
        int max=nums.Max();
        int min=nums.Min();
        int ans=0;
        if(nums.Length<=2){
            return -1;
        }
        for(int i=0;i<nums.Length;i++){
            if(nums[i]!=max && nums[i]!=min){
                ans=nums[i];
            }
        }
        return ans;
    }
}