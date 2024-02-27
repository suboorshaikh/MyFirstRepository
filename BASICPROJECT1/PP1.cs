using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASICPROJECT1
{
    public class PP1
    {
        public void Test()
        {
            IntegerArray();
        }
        public void IntegerArray()
        {
            int[] a = { 1, 2, 3 };
            int[] b = { 1, 2, };
            int[] c = a.Concat(b).ToArray();
            Console.WriteLine( string.Join(", ",c));
        }
    }
}
