using System;

namespace Proverka
{
    public class TDDProverka
    {

        public int AmountNum(string v)
        {
            int count = 0;
            foreach (char c in v)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }
            return count;
        }

        public int AmountSymb(string v)
        {
            return v.Length;
        }

        public int Amounttut(string v1, string v2)
        {
            int count = 0;
            int index = v1.IndexOf(v2);

            while (index != -1)
            {
                count++;
                index = v1.IndexOf(v2, index + 1);
            }

            return count;
        }

        public int AmountWords(string v)
        {
            return v.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public char FindNineSymb(string v)
        {
            if (v.Length >= 9)
            {
                return v[8];
            }
            throw new ArgumentException("Строка короче 9 символов");
        }

        public string FindSHortestWord(string v)
        {
            string[] words = v.Split(' ');
            string shortestWord = words[0];

            foreach (string word in words)
            {
                if (word.Length < shortestWord.Length)
                {
                    shortestWord = word;
                }
            }
            return shortestWord;
        }

        public int MaxNumPodr(string v)
        {
            int maxCount = 0;
            int currentCount = 0;

            foreach (char c in v)
            {
                if (char.IsDigit(c))
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                }
                else
                {
                    currentCount = 0;
                }
            }

            return maxCount;
        }
    }
}