public class Solution {
    
    public bool IsPalindrome(string s)
    {
        string palindrome;

        StringBuilder sb = new(s.Length); 
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsLetterOrDigit(s[i]))
                sb.Append(char.ToLower(s[i] ));
        }
        palindrome = sb.ToString();

        int endPtr = palindrome.Length -1; 
        for (int i = 0; i < palindrome.Length; i++)
        {
            if (palindrome[i] != palindrome[endPtr])
                return false;
            endPtr -= 1; 
        }
        return true; 
    }



}
