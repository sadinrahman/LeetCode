public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int r = FindFirst(nums, target);
        int s = FindLast(nums, target);
        return new int[] { r, s };
    }
    private int FindFirst(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        int result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                result = mid;
                right = mid - 1; 
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return result;
    }

    private int FindLast(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        int result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                result = mid;
                left = mid + 1;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return result;
    }
}