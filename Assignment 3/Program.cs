namespace Assignment_3
{
    internal class Program
    {
       
        static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            int i = 0;
            char temp;
            for(i = 0; i < s.Length; i++)
            {
                if(s[i] == '(' || s[i] == '[' || s[i] == '{') { 
                    stack.Push(s[i]);
                }
                else
                {
                     if(stack.Count == 0)
                        return false;
                     temp = stack.Pop();
                    if((s[i] == ')' && temp != '(') || (s[i] == ']' && temp != '[') || (s[i] == '}' && temp != '{'))
                            return false;
                }
            }
            if(stack.Count == 0)
                return true;
            else
                return false;

        }
        static void Main(string[] args)
        {
            string s = "()[]{}";
            if(IsValid(s))
                Console.WriteLine("The string is valid.");
            else
                Console.WriteLine("The string is not valid.");
        }
    }
}
