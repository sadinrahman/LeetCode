public class Solution {
    public IList<int> AddToArrayForm(int[] num, int k) {
        string nums=String.Join("",num);
        BigInteger x=BigInteger.Parse(nums);
        BigInteger c=k+x;
        List<int> arr = new List<int>(c.ToString().Select(ch => ch - '0'));
        return arr;
    }
}