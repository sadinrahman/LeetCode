public class Solution {
    public string Multiply(string num1, string num2) {
        BigInteger numb1=BigInteger.Parse(num1);
        BigInteger numb2=BigInteger.Parse(num2);
        return (numb1*numb2).ToString();
    }
}