public class Solution {
    static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        if (num == 2 || num == 3) return true;
        if (num % 2 == 0 || num % 3 == 0) return false;

        for (int i = 5; i * i <= num; i += 6)
        {
            if (num % i == 0 || num % (i + 2) == 0)
                return false;
        }
        return true;
    }
    public int CountPrimes(int n) {
        int ans=0;
        for(int i=2;i<n;i++){
            if(IsPrime(i)){
                ans++;
            }
        }
        return ans;
    }
}