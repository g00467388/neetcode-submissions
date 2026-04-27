public class Solution {
    
 public bool IsValid(string s)
    {
        Stack<char> sequence = new();
        if (s.Length <= 1)
            return false;

        foreach (var x in s)
        {
            try
            {
                if (x == '(' || x == '[' || x == '{')
                    sequence.Push(x);

                if (x == ')')
                {
                    if (sequence.Peek() != '(')
                        return false;

                    try
                    {
                        sequence.Pop();
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }

                if (x == '}')
                {
                    if (sequence.Peek() != '{')
                        return false;


                    try
                    {
                        sequence.Pop();
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }

                if (x == ']')
                {
                    if (sequence.Peek() != '[')
                        return false;

                    try
                    {
                        sequence.Pop();
                    }
                    catch (Exception)
                    {
                        return false;
                    }

                }
            }
            catch (Exception)
            {
                return false;
            }

        }

        return sequence.Count == 0;

    }

}
