public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        double ans=0;
        int[] arr=new int[nums1.Length+nums2.Length];
        for(int i=0;i<nums1.Length;i++){
            arr[i]=nums1[i];
        }
        for(int j=0;j<nums2.Length;j++){
            arr[nums1.Length+j]=nums2[j];
        }
        Array.Sort(arr);
        if(arr.Length%2==0){
             double num=arr[arr.Length/2-1]+arr[arr.Length/2];
            ans=num/2;
        }else{
            ans=arr[arr.Length/2];
        }
        return ans;
    }
}