public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var result = new StringBuilder();

        var minLength =strs
        .Select(s => s.Length)
        .Min();

        for(int i=0;i<minLength;i++)
        {
            char current = strs[0][i];

            var charOfIndex = strs.Select(str => str[i]).Where(c => current.Equals(c));

            if(charOfIndex.Count()==strs.Length)
               result.Append(current);
            else
               break;
        }

        return result.ToString();
    }
}
