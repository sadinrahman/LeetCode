public class Solution {
    public int IntegerBreak(int n) {
        if(n<4){
            return n-1;
        }
          int product=1;
          while(n>4){
            product*=3;
            n-=3;
          }   
          product *= n;
          return product;
    }
}