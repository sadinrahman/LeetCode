public class Solution {
    public int Reverse(int x) {
        try{
        bool isNegative = x < 0;
        string num= Math.Abs(x).ToString();
        StringBuilder arr=new StringBuilder();
        for(int i=num.Length-1;i>=0;i--){
            arr.Append(num[i]);
        }
        int ans=Convert.ToInt32(arr.ToString());
        return isNegative ? -ans : ans;
        }catch (OverflowException) {
            return 0; 
        }
    }
}