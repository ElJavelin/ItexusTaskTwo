using System;
using System.Linq;

namespace ItexusTaskTwo
{
    public class BinNumChecker
    {
        public void isGoodBinaryString(string str, string result = "")
        {
            if (String.IsNullOrEmpty(str) || str.Except (new char [] {'0', '1'}).Count() > 0)
            {
                result = $"'{str}' is not a binary number.";
            }
            else if (sNCountEq(str) && checkPrefix(str))
            {
                result = $"'{str}' is a good binary number.";
            }
            else
            {
                result = $"'{str}' is not a good binary number.";
            }

            Console.WriteLine(result);
        }

        private bool checkPrefix(string str)
        {
            for (int i = 0, sL = str.Length - 1; i < str.Length; i++)
            {
                string lStr = str[..^(sL - i)];

                if (lStr.Count(x => x.Equals('1')) < lStr.Count(x => x.Equals('0')))
                {
                    return false;
                }
            }

            return true;
        }
        
        private bool sNCountEq(string str)
        {
            return str.Count(x => x.Equals('0')) == str.Count(x => x.Equals('1')) ? true : false;
        }
    }
}
