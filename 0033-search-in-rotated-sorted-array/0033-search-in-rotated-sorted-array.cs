public class Solution {
    public int Search(int[] nums, int target) {
        if(nums.Contains(target)){
            int i=Array.IndexOf(nums,target);
            return i;
        }else{
            return -1;
        }
    }
}