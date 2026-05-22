public class Solution {
    
    public bool IsPalindrome(string s)
    {
        string palindrome = new([.. s.ToLower().Where(char.IsLetterOrDigit)]);
        int endPtr = palindrome.Length -1; 
        for (int i = 0; i < palindrome.Length; i++)
        {
            if (palindrome[i] != palindrome[endPtr])
                return false;
            endPtr -= 1; 
            Console.WriteLine($"{nameof(endPtr)}: {endPtr}, {nameof(i)}: {i}");
        }
        return true; 
    }


}
