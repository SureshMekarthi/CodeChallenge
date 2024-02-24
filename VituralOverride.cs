using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    internal class VituralOverride
    {

        public class ClassA
        {
            public virtual string Welcome()
            {
                return "welcome from ClassA";
            }
        }

        public class ClassB : ClassA
        {
            public virtual string Welcome()
            {
                return "welcome from class B";
            }
        }

        public class ClassC : ClassB
        {
            public new string Welcome()
            {
                return "welcome from class C";
            }
        }
    }
}
