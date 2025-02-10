public class Solution {
    public string ClearDigits(string s) {
        StringBuilder arr = new StringBuilder();
        
        foreach (char c in s) {
            if (char.IsDigit(c)) {
                if (arr.Length > 0) {
                    arr.Length--; 
                }
            } else {
                arr.Append(c);
            }
        }

        return arr.ToString();
    }
}
