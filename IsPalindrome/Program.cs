using System;

namespace IsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama").ToString());
        }

        public static bool IsPalindrome(string s)
        {


            var array = s.ToCharArray();
            for (int i = 0, j = array.Length - 1; i < j;)
            {
                if (!char.IsLetterOrDigit(array[i]))
                { 
                    i++;
                }
                else if (!char.IsLetterOrDigit(array[j]))
                { 
                    j--;
                }
                else if(char.ToLower(array[i++]) != char.ToLower(array[j--]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
