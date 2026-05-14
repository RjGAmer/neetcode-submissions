class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        n = len(nums)
        res = [1] * n
        
        left = right = 1
        for i in range(n):
            res[i] *= left     
            res[-1-i] *= right  
            left *= nums[i]
            right *= nums[-1-i]
        
        return res
        # n = len(nums)
        # res = [1]*n
        # left =1
        # for i in range(n):
        #     res[i]=left
        #     left*=nums[i]
        # right =1
        # for i in range(n-1,-1,-1):
        #     res[i]*=right
        #     right*=nums[i]
        
        # return res

        


        