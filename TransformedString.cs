using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    internal class TransformedString
    {
        public string Solution(int N)
        {
            StringBuilder sb = new StringBuilder();

            if (N == 1)
            {
                return "a";
            }

            for (int i = 0; i < N; i++)
            {
                sb.Append("a");
            }

            //  var numberOfTransformations = N / 2;

            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == sb[i + 1])
                {
                    sb[i] = (char)(sb[i] + 1);
                    sb[i + 1] = ' ';
                }
            }
            return sb.ToString().Replace(" ", "");
        }
    }
}
