public class Solution {
    public int[] NumberGame(int[] nums) {
        int temp=0;
        int temp2=0;
            for(int i=0;i<nums.Length-1;i++){
                for(int j=0;j<nums.Length-i-1;j++){
                    if(nums[j]>nums[j+1]){
                        temp=nums[j+1];
                        nums[j+1]=nums[j];
                        nums[j]=temp;
                    }
                }
                    
                }
                for(int l=0;l<nums.Length;l=l+2){
                        temp2=nums[l];
                        nums[l]=nums[l+1];
                        nums[l+1]=temp2;
                    }
            
            return nums;
    }
}