public class Solution {
    public int ClimbStairs(int n) {
        if(n==1)return 1;
        if(n==2)return 2;
        int current=0;
        int last1=2;
        int last2=1;
        for(int i=3;i<=n;i++){
            current = last1 + last2;
            last2 = last1;
            last1 = current;
        }
     return current;
    }
}