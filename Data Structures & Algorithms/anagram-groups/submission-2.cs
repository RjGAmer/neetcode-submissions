public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
        foreach (string str in strs) {
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
            string sortedStr = new string(arr);
            if (!result.ContainsKey(sortedStr)) {
                result[sortedStr] = new List<string>();
            }
            result[sortedStr].Add(str);
            ;
        }

        return result.Values.ToList();
    }
}
