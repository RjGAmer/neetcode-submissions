class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        
        the_value = defaultdict(list)
        
        for word in strs:
            my_word = ''.join(sorted(word))
            the_value[my_word].append(word)
        return list(the_value.values())
        