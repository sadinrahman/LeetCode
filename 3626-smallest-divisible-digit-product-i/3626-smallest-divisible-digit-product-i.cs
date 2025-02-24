public class Solution {
    public int SmallestNumber(int n, int t) {
        while (true) {
            int temp = n, product = 1;
            
            while (temp > 0) {
                product *= temp % 10;
                temp /= 10;
            }
            
            if (product % t == 0) {
                return n;  
            }
            
            n++;
        }
    }
}