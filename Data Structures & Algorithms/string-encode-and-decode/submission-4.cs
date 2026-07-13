public class Solution {

    public string Encode(IList<string> strs)
    {
        string result = string.Empty;
        for (int i = 0; i < strs.Count; i++)
        {
            result += $"{strs[i]}†";
        }

        return result;
    }

    public List<string> Decode(string s)
    {
        List<string> result = new();
            string value = string.Empty;
        
        for (int i = 0; i < s.Length; i++)
        {

            if (s[i] == '†')
            {
                result.Add(value);
                value = string.Empty;
            }
            else
                value += s[i];
            
        }

        return result;
    }

}
