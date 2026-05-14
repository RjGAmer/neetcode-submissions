class Solution:
    def isPalindrome(self, s: str) -> bool:
        result = re.sub(r'[^a-zA-Z0-9]', '', s).lower()
        if(result==result[::-1]):
            return True
        else:
            return False

        