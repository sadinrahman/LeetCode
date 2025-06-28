public class Solution {
    public int[] MaxSubsequence(int[] nums, int k) {
        var res = nums.OrderByDescending(x => x).Take(k).ToList();
        var freq = new Dictionary<int, int>();
        foreach (var num in res) {
            if (!freq.ContainsKey(num))
                freq[num] = 0;
            freq[num]++;
        }
        int[] arr = new int[k];
        int index = 0;
        foreach (var num in nums) {
            if (freq.ContainsKey(num) && freq[num] > 0) {
                arr[index++] = num;
                freq[num]--;
                if (index == k) break;
            }
        }
        return arr;
    }
}