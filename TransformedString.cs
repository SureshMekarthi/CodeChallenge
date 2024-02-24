using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public static class TransformedString
    {
        public static string Solution(string input)
        {
            //StringBuilder sb = new StringBuilder();

            //if (N == 1)
            //{
            //    return "a";
            //}

            //for (int i = 0; i < N; i++)
            //{
            //    sb.Append("a");
            //}

            ////  var numberOfTransformations = N / 2;

            //for (int i = 0; i < sb.Length-1; i++)
            //{
            //    if (sb[i] == sb[i + 1])
            //    {
            //        sb[i] = (char)(sb[i] + 1);
            //        sb[i + 1] = ' ';
            //    }
            //}
            //return sb.ToString().Replace(" ", "");


            char[] result = input.ToCharArray();

            for (int i = 0; i < result.Length - 1; i++)
            {
                if (result[i] == result[i + 1])
                {
                    result[i] = (char)(result[i] + 1);
                    result[i + 1] = ' ';
                }
            }

            return new string(result).Replace(" ", "");
        }
    }
}
