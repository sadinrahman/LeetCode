public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0 || (x % 10 == 0 && x != 0)) {
            return false;
        }
        char[] num = x.ToString().ToCharArray();
        for (int i = 0; i < num.Length / 2; i++) {
            if (num[i] != num[num.Length - i - 1]) {
                return false; 
            }
        }
        return true; 
    }
}
