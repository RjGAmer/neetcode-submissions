public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var result = new int[0];
        foreach (int i in nums) {
            var index1 = Array.IndexOf(nums, i);
            for (int j = index1 + 1; j < nums.Length; j++) {
                if (i + nums[j] == target) {
                    result = [index1, j];
                    break;
                }
            }
            if (result.Count() > 0) {
                break;
            }
        }
        return result;
    }
}
