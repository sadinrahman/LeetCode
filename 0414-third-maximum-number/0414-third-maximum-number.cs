public class Solution {
    public int ThirdMax(int[] nums) {
        var arr=nums.Distinct().OrderByDescending(n=>n).ToArray();
        if(arr.Length>=3){
            return arr[2];
        }
        return arr[0];
    }
}