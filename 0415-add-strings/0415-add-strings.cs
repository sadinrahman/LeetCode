public class Solution {
    public string AddStrings(string num1, string num2) {
        BigInteger nums1=BigInteger.Parse(num1);
        BigInteger nums2=BigInteger.Parse(num2);
        return (nums1+nums2).ToString();
    }
}