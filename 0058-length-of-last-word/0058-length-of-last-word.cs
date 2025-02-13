public class Solution {
    public int LengthOfLastWord(string s) {
        string[] arr = s.Split(' '); 
    
        for (int i = arr.Length - 1; i >= 0; i--) {
            if (arr[i].Length > 0) { 
                return arr[i].Length;
            }
        }
        
        return 0;
    }
}
