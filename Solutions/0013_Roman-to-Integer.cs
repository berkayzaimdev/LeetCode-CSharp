public class Solution {
    public int RomanToInt(string s) 
    {
        Dictionary<char, int> map = new();
        map.Add('I',1);
        map.Add('V',5);
        map.Add('X',10);
        map.Add('L',50);
        map.Add('C',100);
        map.Add('D',500);
        map.Add('M',1000);
        int result = 0;

        for(int i=0;i<s.Length;i++)
        {
            if(i!=s.Length-1)
            {
                if(map[s[i]]<map[s[i+1]])
                {
                    result+=map[s[i+1]]-map[s[i]];
                    i++;
                }
                else
                   result+=map[s[i]];
            }
            else
               result+=map[s[i]];
        }
        return result;   
    }
}
