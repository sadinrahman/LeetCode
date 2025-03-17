public class Solution {
    public bool DivideArray(int[] nums) {
        Dictionary<int, int> freq = new Dictionary<int, int>();
        foreach (int num in nums) {
            if (freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num] = 1;
        }
        foreach (var count in freq.Values) {
            if (count % 2 != 0)
                return false;
        }
        return true;
    }
}