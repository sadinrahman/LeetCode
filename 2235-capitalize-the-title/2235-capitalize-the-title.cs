public class Solution {
    public string CapitalizeTitle(string title) {
        string lower=title.ToLower();
        string[] arr=lower.Split(" ");
        for(int i=0;i<arr.Length;i++){
            if(arr[i].Length>2){
            arr[i]=char.ToUpper(arr[i][0]) + arr[i].Substring(1);
        }
        }
        return string.Join(" ",arr);
    }
}