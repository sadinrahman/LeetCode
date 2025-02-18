public class Solution {
    public int[] NumberOfPairs(int[] nums) {
        int[] ans= new int[2];
        int count=0;
        Array.Sort(nums);
        int i=0;
        while (i < nums.Length - 1) {
            if (nums[i] == nums[i + 1]) {
                count++;  
                i += 2;   
            } else {
                i++;      
            }
        }
        ans[0]=count;
        int baki = nums.Length - (count * 2);
        ans[1]=baki;
        return ans; 
    }
}