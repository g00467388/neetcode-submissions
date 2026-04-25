public class Solution {
      public bool hasDuplicate(int[] nums)
    {
        Dictionary<int, int> keyValuePairs = new(); 
        foreach (var item in nums)
        {
            if (keyValuePairs.ContainsKey(item))
                return true; 
            keyValuePairs.Add(item, 1);
            
        }
        return false;
        

    }
}