using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extensions
{
    public static class StringExtensions
    {
        public static string Change(this String str, int numberOfWords) {

            if(numberOfWords < 0)
            {
                throw new ArgumentOutOfRangeException("Number of words should be greater than 0");
            }

            if (numberOfWords == 0)
            {
                return "";
            }

            var words = str.Split(' ');

            if (str.Length < numberOfWords)
            {
                return str;
            }

            return String.Join(" ", words.Take(numberOfWords)) + "...";
           
        }
    }
}
