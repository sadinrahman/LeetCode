public class Solution {
    public int[] SumZero(int n) {
        List<int> arr= new List<int>();
        if (n % 2 == 0) {
            for (int i = 1; i <= n / 2; i++) {
                arr.Add(i);
                arr.Add(-i);
            }
        } else {
            for (int i = 1; i <= n / 2; i++) {
                arr.Add(i);
                arr.Add(-i);
            }
            arr.Add(0);
        }
        if(n==1){
            return new int[] { 0 };
        }
        
        return arr.ToArray();
    }
}
