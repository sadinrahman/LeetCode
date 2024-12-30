public class Solution {
    public int FindGCD(int[] nums) {
        List<int> arr=new List<int>();
        int min=nums.Min();
        int max=nums.Max();
        for(int i=1;i<=min;i++){
            if(min%i==0&&max%i==0){
                arr.Add(i);
            }
        }
        return arr.Max();
    }
}