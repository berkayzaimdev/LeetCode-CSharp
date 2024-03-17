public class Solution {
    public bool IsValid(string s) {
        Stack stack = new Stack();
        var parantheses = new Dictionary<char,char>();
        parantheses.Add('(',')');
        parantheses.Add('{','}');
        parantheses.Add('[',']');

        if(s.Length<2)
           return false;

        foreach(char c in s)
        {
            if(parantheses.ContainsKey(c))
            {
                stack.Push(c);
            }
            else
            {
                if(stack.Count>0 && parantheses[(char)stack.Peek()].Equals(c))
                   stack.Pop();
                else
                   return false;
            }
        }
        return stack.Count==0;
    }
}
