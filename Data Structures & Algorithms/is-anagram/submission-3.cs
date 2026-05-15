public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
        char[] arr1=s.ToCharArray();
        char[] arr2=t.ToCharArray();
        Array.Sort(arr1);
        Array.Sort(arr2);
        if(new string(arr1) == new string(arr2)){
            return true;
        }
        else{
            return false;
        }

    }
}