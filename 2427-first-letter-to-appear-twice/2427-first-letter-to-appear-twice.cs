public class Solution {
    public char RepeatedCharacter(string s) {
     HashSet<char> ans = new HashSet<char>();   
     foreach(var x in s){
        if(ans.Contains(x)){
            return x;
        }
        ans.Add(x);
     }
     return '\0';
    }
}