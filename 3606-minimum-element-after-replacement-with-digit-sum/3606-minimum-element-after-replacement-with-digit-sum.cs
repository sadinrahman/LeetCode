public class Solution {
    public int MinElement(int[] nums) {
        List<int> arr=new List<int>();
        for(int i=0;i<nums.Length;i++){
         int sumOfDigits = nums[i].ToString()
                     .Select(c => c - '0') 
                     .Sum();   
            arr.Add(sumOfDigits);         
        }
        arr.Sort();
        return arr[0];
    }
}