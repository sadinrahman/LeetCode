public class Solution {
    public int GetCommon(int[] nums1, int[] nums2) {
        var common=nums1.Intersect(nums2);
        if (!common.Any()) {
            return -1;  
        }
        return common.Min();
    }
}