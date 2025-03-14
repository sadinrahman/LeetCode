public class Solution {
    public string ReverseStr(string s, int k) {
        List<string> arr = new List<string>();
        for (int i = 0; i < s.Length; i += k)
        {
            arr.Add(s.Substring(i, Math.Min(k, s.Length - i)));
        }
        for(int i=0;i<arr.Count();i=i+2){
            arr[i] = new string(arr[i].Reverse().ToArray());
        }
        return String.Join("",arr);
    }
}