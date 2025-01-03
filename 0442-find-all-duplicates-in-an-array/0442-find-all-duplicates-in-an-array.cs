public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        var duplicates = nums
            .GroupBy(x => x)
            .Where(g => g.Count() > 1)
            .Select(g => g.Key)
            .ToList();
            return duplicates;
    }
}