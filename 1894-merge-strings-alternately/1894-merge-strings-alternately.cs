public class Solution {
    public string MergeAlternately(string word1, string word2) {
        List<char> arr=new List<char>();
        int l=Math.Max(word1.Length,word2.Length);
        for(int i=0;i<l;i++){
            if(i<word1.Length){
                arr.Add(word1[i]);
            }
            if(i<word2.Length){
                arr.Add(word2[i]);
            }
        }
        return new string(arr.ToArray());
    }
}