public class Solution {
    public int MaxProduct(int n) {
        string num=n.ToString();
        int ans=0;
        for (int i = 0; i < num.Length; i++) {
            for (int j = i + 1; j < num.Length; j++) {
                int digit1 = num[i] - '0';
                int digit2 = num[j] - '0';
                int product = digit1 * digit2;
                if (product > ans) {
                    ans = product;
                }
            }
        }
        return ans;
    }
}