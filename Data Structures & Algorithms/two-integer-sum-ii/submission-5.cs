public class Solution {
 public int[] TwoSum(int[] numbers, int target)
    {
        int end = numbers.Length - 1;
        int start = 0; 
        while (start < numbers.Length && end > 0)
        {
            if (numbers[start] + numbers[end] == target)
                return [++start, ++end];
            
            if (numbers[start] + numbers[end] > target)
                end--;
            else 
                start++;
        }
        return [];
    }
}
