public class Solution {
    public string FirstPalindrome(string[] words) {
        for(int i=0;i<words.Length;i++){
        if(words[i]==new string(words[i].Reverse().ToArray())){
            return words[i];
        }
        }
        return "";
    }
}