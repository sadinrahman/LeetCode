public class Solution {
    public int FindFinalValue(int[] nums, int original) {
        int ans=original;
        for(int i=0;i<nums.Length;i++){
            if(ans==nums[i]){
                ans=ans*2;
                i=-1;
            }
        }
        return ans;
    }
}