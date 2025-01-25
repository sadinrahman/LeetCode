public class Solution {
    public string LargestGoodInteger(string num) {
        string largestGoodInteger = string.Empty;

        for (int i = 0; i <= num.Length - 3; i++) {
            if (num[i] == num[i + 1] && num[i + 1] == num[i + 2]) {
                string goodInteger = new string(num[i], 3);

                
                if (string.IsNullOrEmpty(largestGoodInteger) || string.Compare(goodInteger, largestGoodInteger) > 0) {
                    largestGoodInteger = goodInteger;
                }
            }
        }

        return largestGoodInteger;
    }
}
