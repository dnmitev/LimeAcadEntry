using System;
using System.Collections.Generic;
using System.Linq;

namespace Braces
{
    class BracesSolution
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> braces = new List<string>();

            for (int i = 0; i < n; i++)
            {
                var currBraces = Console.ReadLine();
                braces.Add(currBraces);
            }

            var result = CheckMatchingBraces(braces);

            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
        }

        private static IList<string> CheckMatchingBraces(List<string> braces)
        {
            var result = new List<string>();

            foreach (var brace in braces)
            {
                if (IsBalanced(brace))
                {
                    result.Add("YES");
                }
                else
                {
                    result.Add("NO");
                }
            }

            return result;
        }

        private static bool IsBalanced(string input)
        {
            Dictionary<char, char> bracketPairs = new Dictionary<char, char>()
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };

            Stack<char> brackets = new Stack<char>();

            try
            {
                foreach (char c in input)
                {
                    if (bracketPairs.Keys.Contains(c))
                    {
                        brackets.Push(c);
                    }
                    else if (bracketPairs.Values.Contains(c))
                    {
                        if (c == bracketPairs[brackets.First()])
                        {
                            brackets.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            catch
            {
                return false;
            }

            return brackets.Count() == 0 ? true : false;
        }
    }
}
