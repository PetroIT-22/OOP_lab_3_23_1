using System;
using System.Text;

namespace OOP_lab_3_23_1
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();

            string[] words = str.Split(new char[] { ' ', ':', ';', '.', ',', '?', '!', '(', ')', '{', '}', '[', ']', '@', '#', '№', '$', '^', '%', '&', '*' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; ++i)
            {
                if (words[i] == words[i].ToLower())
                {
                    words[i] = words[i].Remove(0);
                }
            }

            string[] modifiedWords = new string[words.Length];

            for (int i = 0; i < words.Length; ++i)
            {
                if (!string.IsNullOrWhiteSpace(words[i]))
                {
                    char[] tempChar = words[i].ToCharArray();
                    char c = tempChar[0];
                    tempChar[0] = tempChar[tempChar.Length - 1];
                    tempChar[tempChar.Length - 1] = c;
                    modifiedWords[i] = new string(tempChar);
                }
            }

            for (int i = 0; i < modifiedWords.Length; ++i)
            {
                if (!string.IsNullOrWhiteSpace(modifiedWords[i]))
                {
                    Console.WriteLine(modifiedWords[i]);
                }
            }
        }
    }
}
