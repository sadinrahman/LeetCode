public class Solution {
    public int[] RearrangeArray(int[] nums) {
        List<int> positive=new List<int>();
        List<int> negative=new List<int>();
        List<int> ans=new List<int>();
        for(int i=0;i<nums.Length;i++){
            if(nums[i]>0){
                positive.Add(nums[i]);
            }else{
                negative.Add(nums[i]);
            }
        }
        for(int i=0;i<positive.Count;i++){
            ans.Add(positive[i]);
            ans.Add(negative[i]);
        }
        return ans.ToArray();
    }
}