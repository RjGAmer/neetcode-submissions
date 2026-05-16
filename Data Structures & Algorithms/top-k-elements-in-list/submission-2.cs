public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // Store frequency
        Dictionary<int, int> freq = new Dictionary<int, int>();

        foreach (int num in nums) {
            if (freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num] = 1;
        }

        // Sort by frequency descending
        var result = freq.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToArray();

        return result;
    }
}
