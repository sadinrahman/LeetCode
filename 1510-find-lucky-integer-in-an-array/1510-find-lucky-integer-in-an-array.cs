public class Solution {
    public int FindLucky(int[] arr) {
        var luckyNumbers = arr.GroupBy(n => n)
                              .Where(g => g.Key == g.Count()) 
                              .Select(g => g.Key);
        return luckyNumbers.Any() ? luckyNumbers.Max() : -1;

    }
}