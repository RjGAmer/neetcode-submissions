class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        tempDict = defaultdict(list)
        for s in strs:
            sortedS=''.join(sorted(s))
            tempDict[sortedS].append(s)
        return list(tempDict.values())
        