public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, List<int>> topCount = new Dictionary<int, List<int>>();

        foreach (int i in nums) {
            if (!topCount.ContainsKey(i)) {
                topCount[i] = new List<int>();
            }
            topCount[i].Add(i);
        }
        if (topCount.Keys.Count == k) {
            return topCount.Keys.ToArray();
        }
        Dictionary<int, List<int>> copyTopCount = new Dictionary<int, List<int>>(topCount);
        var sortedDict = copyTopCount.OrderByDescending(x => x.Value.Count);

        List<int> kFreqent = new List<int>();
        foreach (var item in sortedDict) {
            kFreqent.Add(item.Key);
            if (kFreqent.Count == k) {
                break;
            }
        }
        var freQvalueSort = kFreqent.ToArray();
        Array.Sort(freQvalueSort);
        return freQvalueSort;
    }
}
