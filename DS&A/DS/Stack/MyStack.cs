using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_A.DS.Stack
{
    public class MyStack <T>
    {
        private List<T> items = new List<T>();

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty.");

            T top = items[^1]; // T top = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return top;
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty.");

            return items[^1];
        }

        public bool IsEmpty()
        {
            return items.Count == 0;
        }
    }

    public class ParenthesesValidator
    {
       // "([{}])"     1 -> "{,[,(   -> pop -> [,( -> pop -> ( -> pop -> empty
        public bool IsValidParentheses(string s)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> mapping = new Dictionary<char, char>() {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
            };

            foreach (char c in s)
            {
                if (mapping.ContainsKey(c))
                {
                    char top = stack.Count > 0 ? stack.Pop() : '#';
                    if (top != mapping[c])
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }
            return stack.Count == 0;
        }

        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                        return false;

                    char top = stack.Pop();

                    if ((c == ')' && top != '(') ||
                        (c == '}' && top != '{') ||
                        (c == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
