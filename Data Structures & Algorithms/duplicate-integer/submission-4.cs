public class Solution {
    public bool hasDuplicate(int[] nums)
    {
        List<int> numers  = new List<int>(); 
        bool isdup =false;
        for(int i=0;i<nums.Length;i++)
        {

            if(numers.Contains(nums[i])){
                isdup= true;
                break;
            }
            
            numers.Add(nums[i]);

        }
        if(isdup){
            return true;
        }
        else{
            return false;
        }

        
    }
}