class Solution:

    def encode(self, strs: List[str]) -> str:
        new_str = ""
        for i in strs:
            new_str = new_str+i+"."

        return new_str



    def decode(self, s: str) -> List[str]:
        return s.split(".")[:-1]
