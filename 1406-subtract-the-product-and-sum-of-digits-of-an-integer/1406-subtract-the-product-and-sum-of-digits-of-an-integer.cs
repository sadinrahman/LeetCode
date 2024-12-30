public class Solution {
    public int SubtractProductAndSum(int n) {
        var digits = n.ToString().Select(c => int.Parse(c.ToString()));
        int sum=0;
        foreach(var d in digits){
            sum+=d;
        }
        int product=1;
        foreach(var i in digits){
            product*=i;
        }
        return product-sum;

    }
}