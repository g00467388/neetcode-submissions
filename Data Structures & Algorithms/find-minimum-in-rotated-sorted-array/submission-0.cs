public class Solution {
     public int FindMin(int[] nums)
    {
        if (nums.Length == 0)
            return -1;

        int start = 1; 
        int end = nums.Length - 1;
        int smallest = nums[0];
        while (start <= end)
        {
            smallest = Math.Min(smallest, Math.Min(nums[start], nums[end]));
            end--; 
            start++;
        } 
        return smallest;
    }
}
