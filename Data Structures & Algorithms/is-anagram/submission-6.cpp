class Solution {
public:
bool isAnagram(std::string_view s1, std::string_view s2)
{
    if (s1.length() != s2.length())
        return false;

    std::unordered_map<char, int> hashmap {};
    for (auto& x : s1)
        hashmap[x]++;

   for (auto& x : s2)
   {
       if (hashmap.find(x) == hashmap.end())
           return false;
       if (--hashmap[x] < 0)
           return false;
   }
   return true;
}

  

};
