public class Solution {
    public int BuyChoco(int[] prices, int money) {
        if(prices.Length<2) return money;
        Array.Sort(prices);
        int totalCost = prices[0] + prices[1];
        if(totalCost<=money){
            return money-totalCost;
        }
        return money;
    }
}