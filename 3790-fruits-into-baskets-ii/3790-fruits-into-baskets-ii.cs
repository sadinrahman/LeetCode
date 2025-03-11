public class Solution {
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets) {
        int br=0;
        for(int i=0;i<fruits.Length;i++){
            for(int j=0;j<baskets.Length;j++){
                if(baskets[j] != -1 && baskets[j] >= fruits[i])
                 {
                    baskets[j] = -1;
                    br++;
                    break;
                }
            }
        }
        return fruits.Length-br;
    }
}