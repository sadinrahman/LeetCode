public class Solution {
    public int Search(int[] nums, int target) {
        int ans=Array.BinarySearch(nums,target);
        if(ans<0){
            return -1;
        }
        return ans;
    }
}