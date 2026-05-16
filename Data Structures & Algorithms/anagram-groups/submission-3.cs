public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

        foreach (string word in strs) {
            int[] count = new int[26];

            // Count characters
            foreach (char c in word) {
                count[c - 'a']++;
            }

            // Create unique key
            string key = string.Join(",", count);

            // Create list if not exists
            if (!dict.ContainsKey(key)) {
                dict[key] = new List<string>();
            }

            // Add word
            dict[key].Add(word);
        }

        return dict.Values.ToList();
    }
}
