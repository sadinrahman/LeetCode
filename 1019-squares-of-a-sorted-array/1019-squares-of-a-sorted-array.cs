public class Solution {
    public int[] SortedSquares(int[] nums) {
        int[] arr= new int[nums.Length];
        for(int i=0;i<nums.Length;i++){
            arr[i]=nums[i]*nums[i];
        }
        Array.Sort(arr);
        return arr;
    }
}