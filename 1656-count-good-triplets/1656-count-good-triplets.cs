public class Solution {
    public int CountGoodTriplets(int[] arr, int a, int b, int c) {
        int count=0;
        for(int i=0;i<arr.Length;i++){
            for(int j=0;j<arr.Length;j++){
                if(i<j && Math.Abs(arr[i] - arr[j]) <= a){
                    for(int k=0;k<arr.Length;k++){
                        if(j<k && Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[i] - arr[k]) <= c){
                            count++;
                        }
                    }
                }
            }
        }
        return count;
    }
}