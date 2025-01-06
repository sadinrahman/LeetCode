public class Solution {
    public bool DetectCapitalUse(string word) {
        if (word.All(c => Char.IsUpper(c))) {
            return true;
        }
        if (word.All(c => Char.IsLower(c))) {
            return true;
        }
        if(char.IsUpper(word[0])  && word.Substring(1).All(c => Char.IsLower(c))){
            return true;
        }
        return false;
    }
}