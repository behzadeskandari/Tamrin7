using System;

namespace Tamrin7
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Soal1
            string word = Console.ReadLine();

            string reverseWord = string.Empty;

            string answer = ReverseString(word, reverseWord, word.Length);

            Console.WriteLine(answer);
            ////End Of Soal 1 
            ///Soal 2
            string stringHolder = string.Empty;

            Console.WriteLine("Input a string ");

            stringHolder = Console.ReadLine();
            bool trueOfFalse = PalindromeString(stringHolder);
            if (trueOfFalse)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }


        }
    
        /// <summary>
        /// Soal 1 Soal bar ax kardane string
        /// سوال وسط هفته
        /// </summary>
        /// <param name="word"></param>
        /// <param name="TheWordRevesed"></param>
        /// <param name="index"></param>
        /// <returns></returns>
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
  
    
        /// <summary>
        /// Soal 1 In Hafte
        /// </summary>
        /// <param name="number"></param>
        /// <param name="powerOf"></param>
        /// <returns></returns>
        private static float Pow(float number,int powerOf)
        {
            if (powerOf == 1)
            {
                return 1;
            }
            else
            {
                return number * Pow(number, powerOf - 1);
            }

        }
    
        /// <summary>
        /// Soal 2
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static bool PalindromeString(string txt)
        {
            if (txt.Length <= 1)
            {
                return true;
            }
            else
            {
                if (txt[0] != txt[txt.Length - 1])
                {
                    return false;
                }
                else
                {
                    return PalindromeString(txt.Substring(1, txt.Length - 2));
                }
                
            }
        }
    

        /// <summary>
        /// Soal 3
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int FindBinary(int number)
        {
            if(number == 0)
            {
                return 0;
            }
            else
            {
                return FindBinary(number % 2 * number / 2);
            }

        }

    }

}