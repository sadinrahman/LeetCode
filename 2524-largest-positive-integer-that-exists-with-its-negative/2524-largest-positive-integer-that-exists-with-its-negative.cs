public class Solution {
    public int FindMaxK(int[] nums) {
        int ans=0;
     Array.Sort(nums);
     for(int i=nums.Length-1;i>=0;i--){
        if(nums.Contains(-(nums[i]))){
            ans=Math.Abs(nums[i]);
            break;
        }else{
            ans=-1;
        }
     }
     return ans;
    }
}