public class Solution {
    public bool IsPalindrome(string s) {
       string result = new string(s.Where(char.IsLetterOrDigit)
       .ToArray()).ToLower();
       string reversed = new string(result.Reverse().ToArray());
       return result==reversed;  
    }
}