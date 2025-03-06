public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        int[] ans=new int[2];
        int n=grid.Length;
        List<int> arr=new List<int>();
        for(int i=0;i<n;i++){
            for(int j=0;j<n;j++){
                arr.Add(grid[i][j]);
            }
        }
        var dp= arr.GroupBy(x => x)
                .Where(g => g.Count() > 1) 
                .Select(g => g.Key)
                .FirstOrDefault(); 
        int expectedsum=(n*n*(n*n+1))/2;
        int sum=arr.Sum();
        int missing=expectedsum-sum+dp;
        ans[0]=dp;
        ans[1]=missing;
        return ans;
    }
}