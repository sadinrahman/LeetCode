public class Solution {
    public int[] ApplyOperations(int[] nums) {
        for(int i=0;i<nums.Length-1;i++){
                if(nums[i]==nums[i+1]&&nums[i]!=0){
                    nums[i]*=2;
                    nums[i+1]=0;
                }
        }
        int[] arr=new int[nums.Length];
        int index=0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]!=0){
                arr[index]=nums[i];
                index++;
            }
        }
        return arr;
    }
}