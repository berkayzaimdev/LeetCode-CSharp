public class Solution {
    public int StrStr(string haystack, string needle) 
    {
        if(!haystack.Contains(needle))
           return -1;

        int point=0;

        while(!haystack.Substring(point,needle.Length).Equals(needle))
        {
            point++;
        }    

        return point;
    }
}
