public class Solution {
    public int CountSegments(string s) {
        if (string.IsNullOrWhiteSpace(s)) {
            return 0;
        }
        var ans = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return ans.Length;
    }
}