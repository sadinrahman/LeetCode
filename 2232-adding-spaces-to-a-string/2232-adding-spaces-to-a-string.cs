public class Solution {
    public string AddSpaces(string s, int[] spaces) {
        StringBuilder arr = new StringBuilder(s);
        int r=0;
        for(int i=0;i<spaces.Length;i++){
            arr.Insert(spaces[i]+r," ");
            r++;
        }
        string sh=arr.ToString();
        return sh;
    }
}