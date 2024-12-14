public class Solution {
    public int MajorityElement(int[] nums) {
        var mostRepeated = nums
            .GroupBy(num => num)
            .OrderByDescending(group => group.Count()) 
            .FirstOrDefault();
        return mostRepeated.Max();
    }
}