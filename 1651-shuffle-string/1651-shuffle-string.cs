public class Solution {
    public string RestoreString(string s, int[] indices) {
        string ans="";
        Dictionary<int,char> arr= new Dictionary<int,char>();
        for(int i=0;i<indices.Length;i++){
            arr.Add(indices[i],s[i]);
        }
        var sorted = arr.OrderBy(kv => kv.Key)
        .ToDictionary(kv => kv.Key, kv => kv.Value);
        for(int i=0;i<indices.Length;i++){
            ans+=sorted[i];
        }
        return ans;
    }
}