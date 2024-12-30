public class Solution {
    public string ReverseWords(string s) {
        string[] arr=s.Split(" ");
        for (int i = 0; i < arr.Length; i++) {
            arr[i] = new string(arr[i].Reverse().ToArray());
        }
        return string.Join(" ",arr);
    }
}