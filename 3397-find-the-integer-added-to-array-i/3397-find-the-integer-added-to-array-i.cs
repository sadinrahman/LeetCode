public class Solution {
    public int AddedInteger(int[] nums1, int[] nums2) {
       int result = 0;
        for (var i = 0; i < nums2.Length; i++)
            result += nums2[i] - nums1[i];
        return result / nums1.Length;
    }
    
}