public class Solution {
    public string MakeFancyString(string s) {
        StringBuilder r = new StringBuilder();

        for (int i = 0; i < s.Length; i++) {
            int len = r.Length;
            if (len >= 2 && r[len - 1] == s[i] && r[len - 2] == s[i]) {
                continue;
            }

            r.Append(s[i]);
        }

        return r.ToString();
    }
}