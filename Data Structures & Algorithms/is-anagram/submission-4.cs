public class Solution {
public bool IsAnagram(string s, string t)
    {
        // if strings differ in length, invalid anagram 
        if (s.Length != t.Length)
            return false;

        Dictionary<char, int> dictionary = new();
        foreach (var x in s)
        {
            if (dictionary.ContainsKey(x))
                dictionary[x]++; 
            else 
                dictionary.Add(x, 1);
        }
        foreach (var x in t)
        {
            if (dictionary.ContainsKey(x))
                dictionary[x]--;
            else return false;
            if (dictionary[x] < 0)
                return false;
            
        }
        return true;

    }
}
