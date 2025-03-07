public class Solution {
    public int[] ClosestPrimes(int left, int right) {
        int[] ans=new int[2];
        List<int> arr=new List<int>();
        for(int i=left;i<=right;i++){
            if(IsPrime(i)){
                arr.Add(i);
            }
        }
        if(arr.Count()<2){
            return [-1,-1];
        }
        int minDiff = int.MaxValue;
       for (int i = 1; i < arr.Count; i++) {
            int diff = arr[i] - arr[i - 1];
            if (diff < minDiff) {
                minDiff = diff;
                ans[0] = arr[i - 1];
                ans[1] = arr[i];
            }
        }
        return ans;
    }
    private bool IsPrime(int num) {
        if (num < 2) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;

        for (int i = 3; i * i <= num; i += 2) {
            if (num % i == 0) return false;
        }

        return true;
    }
}