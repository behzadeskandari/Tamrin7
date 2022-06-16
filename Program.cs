using System;

namespace Tamrin7
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    
    
        public static string ReverseString(string word,string TheWordRevesed,int index)
        {
            if (index > 0)
            {
                index--;
                TheWordRevesed = TheWordRevesed + word[index];
                return ReverseString(word, TheWordRevesed, index);
            }
            else
            {
                return TheWordRevesed;
            }
        }
    }

}
