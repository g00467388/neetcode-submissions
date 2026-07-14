public class Solution {
     public bool IsPalindrome(string s)
    {
        string result = string.Empty;
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsLetterOrDigit(s[i]))
                result += char.ToLower(s[i]);
        }
        return result == new string(result.Reverse().ToArray());
    }
}
