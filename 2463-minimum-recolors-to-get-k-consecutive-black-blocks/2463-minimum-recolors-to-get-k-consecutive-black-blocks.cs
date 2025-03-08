public class Solution {
    public int MinimumRecolors(string blocks, int k) {
        int ans=int.MaxValue;
        for(int i=0;i<=blocks.Length-k;i++){
            int count=0;
            for(int j=i;j<i+k;j++){
                if(blocks[j]=='W'){
                    count++;
                }
            }
             ans=Math.Min(count,ans);
        }
        return ans;
    }
}