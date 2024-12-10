public class Solution {
    public int SumOddLengthSubarrays(int[] arr) {
        int ans=0;
        for(int i=0;i<arr.Length;i++){
            int total=(i+1)*(arr.Length-i);
            int odd = (total+ 1) / 2;
            ans += arr[i] * odd;
        }
        return ans;
    }
}