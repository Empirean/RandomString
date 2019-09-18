using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomString
{
    class RandomGen
    {

        readonly Random rnd;

        const string defaultTextPool = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        string textPool = defaultTextPool;

        int maxLength = 16;

        public RandomGen()
        {
            rnd = new Random();
        }

        public string getString()
        {

            string temp = "";

            for (int i = 0; i < maxLength; i++)
            {
                temp = temp + textPool.Substring(rnd.Next(0, textPool.Length), 1);
            }

            return temp;
        }

        public void setMaxLength(int i)
        {
            maxLength = i;
        }

        public int getMaxLength()
        {
            return maxLength;
        }

        public void addSymbols(string symbols)
        {
            textPool = defaultTextPool;
            textPool = textPool + symbols;
        }

    }

}
