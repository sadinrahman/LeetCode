public class Solution {
    public IList<string> StringMatching(string[] words) {
        HashSet<string> arr = new HashSet<string>();
        for(int i=0;i<words.Length;i++){
            for(int j=0;j<words.Length;j++){
                if(j!=i  && words[i].Contains(words[j])){
                    arr.Add(words[j]);
                }
            }
        }
        return arr.ToList(
            
        );
    }
}