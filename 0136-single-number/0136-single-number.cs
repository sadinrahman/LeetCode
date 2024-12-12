public class Solution {
    public int SingleNumber(int[] nums) {
        var ans= nums.GroupBy(x => x)
                     .Where(g => g.Count() == 1)
                     .Select(g => g.Key)
                     .FirstOrDefault();
        return ans;
    }
}