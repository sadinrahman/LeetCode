public class Solution {
    public int SumOfGoodNumbers(int[] nums, int k) {
        int sum=0;
        for(int i=0;i<nums.Length;i++){
            bool isgood=true;
            if (i - k >= 0 && nums[i] <= nums[i - k]) {
                isgood = false;
            }
            if (i + k < nums.Length && nums[i] <= nums[i + k]) {
                isgood = false;
            }
            if(isgood){
                sum+=nums[i];
            }
        }
        return sum;
    }
}