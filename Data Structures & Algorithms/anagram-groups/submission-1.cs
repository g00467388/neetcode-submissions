public class Solution {
    public List<List<string>> GroupAnagrams(string[] array)
    {
        if (array.Length == 0)
            return [];

        Dictionary<string, List<string>> anagrams = new(); 
        for (int i = 0; i < array.Length; i++)
        {
            var word = array[i].ToCharArray();
            Array.Sort(word);
            var sorted = new string(word);
            if (anagrams.ContainsKey(sorted))
                anagrams[sorted].Add(array[i]);
            else 
                anagrams.Add(sorted, new List<string>() {array[i]});
        }

        return anagrams.Values.ToList();
    }
}
