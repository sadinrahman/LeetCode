public class Solution {
    public string ReverseWords(string s) {
        string[] arr=s.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
        arr=arr.Select(s=>s.Trim()).ToArray();
        Array.Reverse(arr);
        return String.Join(" ",arr);
    }
}