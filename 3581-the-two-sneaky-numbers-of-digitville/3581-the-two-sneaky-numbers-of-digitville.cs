public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        Array.Sort(nums);
        var duplicates=new List<int>();
        for(int i=1;i<nums.Length;i++){
            if(nums[i]==nums[i-1]){
                duplicates.Add(nums[i]);
            }
        }
        return duplicates.ToArray();
    }
}