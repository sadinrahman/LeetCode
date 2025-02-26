public class Solution {
    public int NumOfSubarrays(int[] arr) {
        int count = 0, prefixSum = 0;
        int oddCount = 0, evenCount = 1; 
        int MOD = 1_000_000_007;

        for (int i = 0; i < arr.Length; i++) {
            prefixSum += arr[i]; 
            if (prefixSum % 2 == 0) { 
                count = (count + oddCount) % MOD; 
                evenCount++;  
            } else {
                count = (count + evenCount) % MOD; 
                oddCount++;
            }
        }
        return count;
    }
}
