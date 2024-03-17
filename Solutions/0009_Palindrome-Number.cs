public class Solution {
    public bool IsPalindrome(int x) {
        string stringX = x.ToString();
        
        // for 1234321; it should check if 1-1, 2-2 and 3-3 are equal
        for(int i=0;i<stringX.Length/2;i++)
        {
            if(stringX[i]!=stringX[stringX.Length-1-i])
               return false;
        }
        return true;
    }
}
