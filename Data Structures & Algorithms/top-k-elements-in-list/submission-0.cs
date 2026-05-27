public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> elementCounts = new(); 
        for (int i = 0; i < nums.Length; i++)
        {
            if (elementCounts.ContainsKey(nums[i]))
                elementCounts[nums[i]]++;

            else 
                elementCounts.Add(nums[i], 0);
        }
        return [.. elementCounts.OrderByDescending(p => p.Value).Take(k).Select(p => p.Key)];
    }
}
